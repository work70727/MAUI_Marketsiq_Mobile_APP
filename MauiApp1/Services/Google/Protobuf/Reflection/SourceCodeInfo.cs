﻿using System.Diagnostics;
using MarketsIQ.Services.Google.Protobuf.Collections;

namespace MarketsIQ.Services.Google.Protobuf.Reflection
{
    internal sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IMessage, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>
    {
        [DebuggerNonUserCode]
        public static class Types
        {
            internal sealed class Location : IMessage<Location>, IMessage, IEquatable<Location>, IDeepCloneable<Location>
            {
                private static readonly MessageParser<Location> _parser = new MessageParser<Location>(() => new Location());

                private UnknownFieldSet _unknownFields;

                public const int PathFieldNumber = 1;

                private static readonly FieldCodec<int> _repeated_path_codec = FieldCodec.ForInt32(10u);

                private readonly RepeatedField<int> path_ = new RepeatedField<int>();

                public const int SpanFieldNumber = 2;

                private static readonly FieldCodec<int> _repeated_span_codec = FieldCodec.ForInt32(18u);

                private readonly RepeatedField<int> span_ = new RepeatedField<int>();

                public const int LeadingCommentsFieldNumber = 3;

                private string leadingComments_ = "";

                public const int TrailingCommentsFieldNumber = 4;

                private string trailingComments_ = "";

                public const int LeadingDetachedCommentsFieldNumber = 6;

                private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec = FieldCodec.ForString(50u);

                private readonly RepeatedField<string> leadingDetachedComments_ = new RepeatedField<string>();

                [DebuggerNonUserCode]
                public static MessageParser<Location> Parser => _parser;

                [DebuggerNonUserCode]
                public static MessageDescriptor Descriptor => SourceCodeInfo.Descriptor.NestedTypes[0];

                [DebuggerNonUserCode]
                MessageDescriptor IMessage.Descriptor => Descriptor;

                [DebuggerNonUserCode]
                public RepeatedField<int> Path => path_;

                [DebuggerNonUserCode]
                public RepeatedField<int> Span => span_;

                [DebuggerNonUserCode]
                public string LeadingComments
                {
                    get
                    {
                        return leadingComments_;
                    }
                    set
                    {
                        leadingComments_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                [DebuggerNonUserCode]
                public string TrailingComments
                {
                    get
                    {
                        return trailingComments_;
                    }
                    set
                    {
                        trailingComments_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                [DebuggerNonUserCode]
                public RepeatedField<string> LeadingDetachedComments => leadingDetachedComments_;

                [DebuggerNonUserCode]
                public Location()
                {
                }

                [DebuggerNonUserCode]
                public Location(Location other)
                    : this()
                {
                    path_ = other.path_.Clone();
                    span_ = other.span_.Clone();
                    leadingComments_ = other.leadingComments_;
                    trailingComments_ = other.trailingComments_;
                    leadingDetachedComments_ = other.leadingDetachedComments_.Clone();
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                [DebuggerNonUserCode]
                public Location Clone()
                {
                    return new Location(this);
                }

                [DebuggerNonUserCode]
                public override bool Equals(object other)
                {
                    return Equals(other as Location);
                }

                [DebuggerNonUserCode]
                public bool Equals(Location other)
                {
                    if (other == null)
                    {
                        return false;
                    }

                    if (other == this)
                    {
                        return true;
                    }

                    if (!path_.Equals(other.path_))
                    {
                        return false;
                    }

                    if (!span_.Equals(other.span_))
                    {
                        return false;
                    }

                    if (LeadingComments != other.LeadingComments)
                    {
                        return false;
                    }

                    if (TrailingComments != other.TrailingComments)
                    {
                        return false;
                    }

                    if (!leadingDetachedComments_.Equals(other.leadingDetachedComments_))
                    {
                        return false;
                    }

                    return object.Equals(_unknownFields, other._unknownFields);
                }

                [DebuggerNonUserCode]
                public override int GetHashCode()
                {
                    int num = 1;
                    num ^= path_.GetHashCode();
                    num ^= span_.GetHashCode();
                    if (LeadingComments.Length != 0)
                    {
                        num ^= LeadingComments.GetHashCode();
                    }

                    if (TrailingComments.Length != 0)
                    {
                        num ^= TrailingComments.GetHashCode();
                    }

                    num ^= leadingDetachedComments_.GetHashCode();
                    if (_unknownFields != null)
                    {
                        num ^= _unknownFields.GetHashCode();
                    }

                    return num;
                }

                [DebuggerNonUserCode]
                public override string ToString()
                {
                    return JsonFormatter.ToDiagnosticString(this);
                }

                [DebuggerNonUserCode]
                public void WriteTo(CodedOutputStream output)
                {
                    path_.WriteTo(output, _repeated_path_codec);
                    span_.WriteTo(output, _repeated_span_codec);
                    if (LeadingComments.Length != 0)
                    {
                        output.WriteRawTag(26);
                        output.WriteString(LeadingComments);
                    }

                    if (TrailingComments.Length != 0)
                    {
                        output.WriteRawTag(34);
                        output.WriteString(TrailingComments);
                    }

                    leadingDetachedComments_.WriteTo(output, _repeated_leadingDetachedComments_codec);
                    if (_unknownFields != null)
                    {
                        _unknownFields.WriteTo(output);
                    }
                }

                [DebuggerNonUserCode]
                public int CalculateSize()
                {
                    int num = 0;
                    num += path_.CalculateSize(_repeated_path_codec);
                    num += span_.CalculateSize(_repeated_span_codec);
                    if (LeadingComments.Length != 0)
                    {
                        num += 1 + CodedOutputStream.ComputeStringSize(LeadingComments);
                    }

                    if (TrailingComments.Length != 0)
                    {
                        num += 1 + CodedOutputStream.ComputeStringSize(TrailingComments);
                    }

                    num += leadingDetachedComments_.CalculateSize(_repeated_leadingDetachedComments_codec);
                    if (_unknownFields != null)
                    {
                        num += _unknownFields.CalculateSize();
                    }

                    return num;
                }

                [DebuggerNonUserCode]
                public void MergeFrom(Location other)
                {
                    if (other != null)
                    {
                        path_.Add(other.path_);
                        span_.Add(other.span_);
                        if (other.LeadingComments.Length != 0)
                        {
                            LeadingComments = other.LeadingComments;
                        }

                        if (other.TrailingComments.Length != 0)
                        {
                            TrailingComments = other.TrailingComments;
                        }

                        leadingDetachedComments_.Add(other.leadingDetachedComments_);
                        _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
                    }
                }

                [DebuggerNonUserCode]
                public void MergeFrom(CodedInputStream input)
                {
                    uint num;
                    while ((num = input.ReadTag()) != 0)
                    {
                        switch (num)
                        {
                            default:
                                _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                                break;
                            case 8u:
                            case 10u:
                                path_.AddEntriesFrom(input, _repeated_path_codec);
                                break;
                            case 16u:
                            case 18u:
                                span_.AddEntriesFrom(input, _repeated_span_codec);
                                break;
                            case 26u:
                                LeadingComments = input.ReadString();
                                break;
                            case 34u:
                                TrailingComments = input.ReadString();
                                break;
                            case 50u:
                                leadingDetachedComments_.AddEntriesFrom(input, _repeated_leadingDetachedComments_codec);
                                break;
                        }
                    }
                }
            }
        }

        private static readonly MessageParser<SourceCodeInfo> _parser = new MessageParser<SourceCodeInfo>(() => new SourceCodeInfo());

        private UnknownFieldSet _unknownFields;

        public const int LocationFieldNumber = 1;

        private static readonly FieldCodec<Types.Location> _repeated_location_codec = FieldCodec.ForMessage(10u, Types.Location.Parser);

        private readonly RepeatedField<Types.Location> location_ = new RepeatedField<Types.Location>();

        [DebuggerNonUserCode]
        public static MessageParser<SourceCodeInfo> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[19];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public RepeatedField<Types.Location> Location => location_;

        [DebuggerNonUserCode]
        public SourceCodeInfo()
        {
        }

        [DebuggerNonUserCode]
        public SourceCodeInfo(SourceCodeInfo other)
            : this()
        {
            location_ = other.location_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public SourceCodeInfo Clone()
        {
            return new SourceCodeInfo(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as SourceCodeInfo);
        }

        [DebuggerNonUserCode]
        public bool Equals(SourceCodeInfo other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (!location_.Equals(other.location_))
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            num ^= location_.GetHashCode();
            if (_unknownFields != null)
            {
                num ^= _unknownFields.GetHashCode();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public override string ToString()
        {
            return JsonFormatter.ToDiagnosticString(this);
        }

        [DebuggerNonUserCode]
        public void WriteTo(CodedOutputStream output)
        {
            location_.WriteTo(output, _repeated_location_codec);
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [DebuggerNonUserCode]
        public int CalculateSize()
        {
            int num = 0;
            num += location_.CalculateSize(_repeated_location_codec);
            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(SourceCodeInfo other)
        {
            if (other != null)
            {
                location_.Add(other.location_);
                _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
            }
        }

        [DebuggerNonUserCode]
        public void MergeFrom(CodedInputStream input)
        {
            uint num;
            while ((num = input.ReadTag()) != 0)
            {
                if (num != 10)
                {
                    _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                }
                else
                {
                    location_.AddEntriesFrom(input, _repeated_location_codec);
                }
            }
        }
    }
}
