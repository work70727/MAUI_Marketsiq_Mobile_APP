﻿using System.Diagnostics;
using System.Globalization;
using System.Text;
using MarketsIQ.Services.Google.Protobuf.Reflection;

namespace MarketsIQ.Services.Google.Protobuf.WellKnownTypes
{
    public sealed class Duration : IMessage<Duration>, IMessage, IEquatable<Duration>, IDeepCloneable<Duration>, ICustomDiagnosticMessage
    {
        private static readonly MessageParser<Duration> _parser = new MessageParser<Duration>(() => new Duration());

        private UnknownFieldSet _unknownFields;

        public const int SecondsFieldNumber = 1;

        private long seconds_;

        public const int NanosFieldNumber = 2;

        private int nanos_;

        public const int NanosecondsPerSecond = 1000000000;

        public const int NanosecondsPerTick = 100;

        public const long MaxSeconds = 315576000000L;

        public const long MinSeconds = -315576000000L;

        internal const int MaxNanoseconds = 999999999;

        internal const int MinNanoseconds = -999999999;

        [DebuggerNonUserCode]
        public static MessageParser<Duration> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => DurationReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public long Seconds
        {
            get
            {
                return seconds_;
            }
            set
            {
                seconds_ = value;
            }
        }

        [DebuggerNonUserCode]
        public int Nanos
        {
            get
            {
                return nanos_;
            }
            set
            {
                nanos_ = value;
            }
        }

        [DebuggerNonUserCode]
        public Duration()
        {
        }

        [DebuggerNonUserCode]
        public Duration(Duration other)
            : this()
        {
            seconds_ = other.seconds_;
            nanos_ = other.nanos_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public Duration Clone()
        {
            return new Duration(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as Duration);
        }

        [DebuggerNonUserCode]
        public bool Equals(Duration other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (Seconds != other.Seconds)
            {
                return false;
            }

            if (Nanos != other.Nanos)
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (Seconds != 0L)
            {
                num ^= Seconds.GetHashCode();
            }

            if (Nanos != 0)
            {
                num ^= Nanos.GetHashCode();
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
            if (Seconds != 0L)
            {
                output.WriteRawTag(8);
                output.WriteInt64(Seconds);
            }

            if (Nanos != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(Nanos);
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
            if (Seconds != 0L)
            {
                num += 1 + CodedOutputStream.ComputeInt64Size(Seconds);
            }

            if (Nanos != 0)
            {
                num += 1 + CodedOutputStream.ComputeInt32Size(Nanos);
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(Duration other)
        {
            if (other != null)
            {
                if (other.Seconds != 0L)
                {
                    Seconds = other.Seconds;
                }

                if (other.Nanos != 0)
                {
                    Nanos = other.Nanos;
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
                switch (num)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 8u:
                        Seconds = input.ReadInt64();
                        break;
                    case 16u:
                        Nanos = input.ReadInt32();
                        break;
                }
            }
        }

        internal static bool IsNormalized(long seconds, int nanoseconds)
        {
            if (seconds < -315576000000L || seconds > 315576000000L || nanoseconds < -999999999 || nanoseconds > 999999999)
            {
                return false;
            }

            return Math.Sign(seconds) * Math.Sign(nanoseconds) != -1;
        }

        public TimeSpan ToTimeSpan()
        {
            if (!IsNormalized(Seconds, Nanos))
            {
                throw new InvalidOperationException("Duration was not a valid normalized duration");
            }

            checked
            {
                return TimeSpan.FromTicks(Seconds * 10000000 + unchecked(Nanos / 100));
            }
        }

        public static Duration FromTimeSpan(TimeSpan timeSpan)
        {
            long ticks = timeSpan.Ticks;
            long seconds = ticks / 10000000;
            checked
            {
                int nanos = (int)unchecked(ticks % 10000000) * 100;
                return new Duration
                {
                    Seconds = seconds,
                    Nanos = nanos
                };
            }
        }

        public static Duration operator -(Duration value)
        {
            ProtoPreconditions.CheckNotNull(value, "value");
            return checked(Normalize(-value.Seconds, -value.Nanos));
        }

        public static Duration operator +(Duration lhs, Duration rhs)
        {
            ProtoPreconditions.CheckNotNull(lhs, "lhs");
            ProtoPreconditions.CheckNotNull(rhs, "rhs");
            return checked(Normalize(lhs.Seconds + rhs.Seconds, lhs.Nanos + rhs.Nanos));
        }

        public static Duration operator -(Duration lhs, Duration rhs)
        {
            ProtoPreconditions.CheckNotNull(lhs, "lhs");
            ProtoPreconditions.CheckNotNull(rhs, "rhs");
            return checked(Normalize(lhs.Seconds - rhs.Seconds, lhs.Nanos - rhs.Nanos));
        }

        internal static Duration Normalize(long seconds, int nanoseconds)
        {
            int num = nanoseconds / 1000000000;
            seconds += num;
            nanoseconds -= num * 1000000000;
            if (seconds < 0 && nanoseconds > 0)
            {
                seconds++;
                nanoseconds -= 1000000000;
            }
            else if (seconds > 0 && nanoseconds < 0)
            {
                seconds--;
                nanoseconds += 1000000000;
            }

            return new Duration
            {
                Seconds = seconds,
                Nanos = nanoseconds
            };
        }

        internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
        {
            if (IsNormalized(seconds, nanoseconds))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append('"');
                if (seconds == 0L && nanoseconds < 0)
                {
                    stringBuilder.Append('-');
                }

                stringBuilder.Append(seconds.ToString("d", CultureInfo.InvariantCulture));
                AppendNanoseconds(stringBuilder, Math.Abs(nanoseconds));
                stringBuilder.Append("s\"");
                return stringBuilder.ToString();
            }

            if (diagnosticOnly)
            {
                return string.Format(CultureInfo.InvariantCulture, "{{ \"@warning\": \"Invalid Duration\", \"seconds\": \"{0}\", \"nanos\": {1} }}", new object[2] { seconds, nanoseconds });
            }

            throw new InvalidOperationException("Non-normalized duration value");
        }

        public string ToDiagnosticString()
        {
            return ToJson(Seconds, Nanos, diagnosticOnly: true);
        }

        internal static void AppendNanoseconds(StringBuilder builder, int nanos)
        {
            if (nanos != 0)
            {
                builder.Append('.');
                if (nanos % 1000000 == 0)
                {
                    builder.Append((nanos / 1000000).ToString("d3", CultureInfo.InvariantCulture));
                }
                else if (nanos % 1000 == 0)
                {
                    builder.Append((nanos / 1000).ToString("d6", CultureInfo.InvariantCulture));
                }
                else
                {
                    builder.Append(nanos.ToString("d9", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
