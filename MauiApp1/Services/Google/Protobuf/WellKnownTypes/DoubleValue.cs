﻿using System.Diagnostics;
using MarketsIQ.Services.Google.Protobuf.Collections;
using MarketsIQ.Services.Google.Protobuf.Reflection;

namespace MarketsIQ.Services.Google.Protobuf.WellKnownTypes
{
    public sealed class DoubleValue : IMessage<DoubleValue>, IMessage, IEquatable<DoubleValue>, IDeepCloneable<DoubleValue>
    {
        private static readonly MessageParser<DoubleValue> _parser = new MessageParser<DoubleValue>(() => new DoubleValue());

        private UnknownFieldSet _unknownFields;

        public const int ValueFieldNumber = 1;

        private double value_;

        [DebuggerNonUserCode]
        public static MessageParser<DoubleValue> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public double Value
        {
            get
            {
                return value_;
            }
            set
            {
                value_ = value;
            }
        }

        [DebuggerNonUserCode]
        public DoubleValue()
        {
        }

        [DebuggerNonUserCode]
        public DoubleValue(DoubleValue other)
            : this()
        {
            value_ = other.value_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public DoubleValue Clone()
        {
            return new DoubleValue(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as DoubleValue);
        }

        [DebuggerNonUserCode]
        public bool Equals(DoubleValue other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Value, other.Value))
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (Value != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Value);
            }

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
            if (Value != 0.0)
            {
                output.WriteRawTag(9);
                output.WriteDouble(Value);
            }

            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [DebuggerNonUserCode]
        public int CalculateSize()
        {
            int num = 0;
            if (Value != 0.0)
            {
                num += 9;
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(DoubleValue other)
        {
            if (other != null)
            {
                if (other.Value != 0.0)
                {
                    Value = other.Value;
                }

                _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
            }
        }

        [DebuggerNonUserCode]
        public void MergeFrom(CodedInputStream input)
        {
            uint num;
            while ((num = input.ReadTag()) != 0)
            {
                if (num != 9)
                {
                    _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                }
                else
                {
                    Value = input.ReadDouble();
                }
            }
        }
    }
}
