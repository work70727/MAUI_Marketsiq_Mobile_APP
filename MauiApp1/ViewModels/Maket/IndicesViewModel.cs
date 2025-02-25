﻿using MarketsIQ.Models.Market;
using MarketsIQ.Services;
using MarketsIQ.Services.Quantower.API.Client;
using MarketsIQ.Services.Quantower.API.Client.Models;
using MarketsIQ.Services.Quantower.API.Client.Models.Quotes;
using System.Collections.ObjectModel;

namespace MarketsIQ.ViewModels.Maket
{
    class IndicesViewModel
    {
        private IList<QInstrument> Symbols {  get; set; }
        private QApiClient _client;

        public ObservableCollection<BaseSymbolModel> Lists { get; set; } = new ObservableCollection<BaseSymbolModel>();

        public IndicesViewModel(MarketsIQService connectService)
        {
            Symbols = MarketsIQService.Instruments.Take(2).ToList();
            _client = MarketsIQService.qApiClient;

            foreach (QInstrument instrument in Symbols)
            {
                Lists.Add(new BaseSymbolModel
                {
                    InstrumentId = instrument.Id,
                    Instrument = instrument,
                    TradeQuote = null
                });
                _client.Quotes.Subscribe(instrument.Id, QMarketQuoteType.Trade);
            }

            _client.Quotes.MarketQuoteReceived += this.CellSubscribe;
        }

        public void CellSubscribe(object sender, QEventArgs e)
        {
            if (e.MarketData is QTradeQuote qTrade)
            {
                var list = Lists.FirstOrDefault(l => l.InstrumentId == qTrade.InstrumentId);
                if (list != null)
                {
                    list.TradeQuote = qTrade;
                }
            }
        }
    }
}
