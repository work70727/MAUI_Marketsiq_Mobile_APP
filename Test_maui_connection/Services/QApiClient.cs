﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_maui_connection.Services
{
    class QApiClient
    {
        public static QApiClient _qApiClient;

        public QApiClient (string apiKey)
        {
            _qApiClient = new QApiClient (apiKey);
        }
    }
}
