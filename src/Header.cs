﻿using BeetleX.Buffers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeetleX.FastHttpApi
{
    public class HeaderType
    {
        static HeaderType()
        {
            SPACE_BYTES = Encoding.UTF8.GetBytes(" ");
            HEADER_SPLIT = Encoding.UTF8.GetBytes(": ");
            LINE_BYTES = Encoding.UTF8.GetBytes("\r\n");
            NULL_CONTENT_LENGTH_BYTES = Encoding.UTF8.GetBytes("Content-Length: 0\r\n");
            CHUNKED_BYTES = Encoding.UTF8.GetBytes("0\r\n\r\n");
            ACCEPT_BYTES = Encoding.UTF8.GetBytes(ACCEPT + ": ");
            ACCEPT_ENCODING_BYTES = Encoding.UTF8.GetBytes(ACCEPT_ENCODING + ": ");
            ACCEPT_LANGUAGE_BYTES = Encoding.UTF8.GetBytes(ACCEPT_LANGUAGE + ": ");
            CACHE_CONTROL_BYTES = Encoding.UTF8.GetBytes(CACHE_CONTROL + ": ");
            CONNECTION_BYTES = Encoding.UTF8.GetBytes(CONNECTION + ": ");
            COOKIE_BYTES = Encoding.UTF8.GetBytes(COOKIE + ": ");
            REFERER_BYTES = Encoding.UTF8.GetBytes(REFERER + ": ");
            USER_AGENT_BYTES = Encoding.UTF8.GetBytes(USER_AGENT + ": ");
            STATUS_BYTES = Encoding.UTF8.GetBytes(STATUS + ": ");
            CONTENT_TYPE_BYTES = Encoding.UTF8.GetBytes(CONTENT_TYPE + ": ");
            ETAG_BYTES = Encoding.UTF8.GetBytes(ETAG + ": ");
            CONTENT_LENGTH_BYTES = Encoding.UTF8.GetBytes(CONTENT_LENGTH + ": ");
            CONTENT_ENCODING_BYTES = Encoding.UTF8.GetBytes(CONTENT_ENCODING + ": ");
            TRANSFER_ENCODING_BYTES = Encoding.UTF8.GetBytes(TRANSFER_ENCODING + ": ");
            IF_NONE_MATCH_BYTES = Encoding.UTF8.GetBytes(IF_NONE_MATCH + ": ");
            SERVER_BYTES = Encoding.UTF8.GetBytes(SERVER + ": ");
            SET_COOKIE_BYTES = Encoding.UTF8.GetBytes(SET_COOKIE + ": ");
        }

        public static void Write(string name, PipeStream stream)
        {
            if (name[0] == 'A')
            {
                switch (name)
                {
                    case ACCEPT:
                        stream.Write(ACCEPT_BYTES, 0, ACCEPT_BYTES.Length);
                        break;
                    case ACCEPT_ENCODING:
                        stream.Write(ACCEPT_ENCODING_BYTES, 0, ACCEPT_ENCODING_BYTES.Length);
                        break;
                    case ACCEPT_LANGUAGE:
                        stream.Write(ACCEPT_LANGUAGE_BYTES, 0, ACCEPT_LANGUAGE_BYTES.Length);
                        break;
                    default:
                        stream.Write(name + ": ");
                        break;
                }
            }
            else if (name[0] == 'C')
            {
                switch (name)
                {
                    case CACHE_CONTROL:
                        stream.Write(CACHE_CONTROL_BYTES, 0, CACHE_CONTROL_BYTES.Length);
                        break;
                    case CONNECTION:
                        stream.Write(CONNECTION_BYTES, 0, CONNECTION_BYTES.Length);
                        break;
                    case COOKIE:
                        stream.Write(COOKIE_BYTES, 0, COOKIE_BYTES.Length);
                        break;
                    case CONTENT_LENGTH:
                        stream.Write(CONTENT_LENGTH_BYTES, 0, CONTENT_LENGTH_BYTES.Length);
                        break;
                    case CONTENT_ENCODING:
                        stream.Write(CONTENT_ENCODING_BYTES, 0, CONTENT_ENCODING_BYTES.Length);
                        break;
                    case CONTENT_TYPE:
                        stream.Write(CONTENT_TYPE_BYTES, 0, CONTENT_TYPE_BYTES.Length);
                        break;
                    default:
                        stream.Write(name + ": ");
                        break;
                }
            }
            else if (name[0] == 'S')
            {
                switch (name)
                {
                    case STATUS:
                        stream.Write(STATUS_BYTES, 0, STATUS_BYTES.Length);
                        break;
                    case SERVER:
                        stream.Write(SERVER_BYTES, 0, SERVER_BYTES.Length);
                        break;
                    case SET_COOKIE:
                        stream.Write(SET_COOKIE_BYTES, 0, SET_COOKIE_BYTES.Length);
                        break;
                    default:
                        stream.Write(name + ": ");
                        break;
                }
            }
            else
            {
                switch (name)
                {
                    case REFERER:
                        stream.Write(REFERER_BYTES, 0, REFERER_BYTES.Length);
                        break;
                    case USER_AGENT:
                        stream.Write(USER_AGENT_BYTES, 0, USER_AGENT_BYTES.Length);
                        break;
                    case ETAG:
                        stream.Write(ETAG_BYTES, 0, ETAG_BYTES.Length);
                        break;
                    case TRANSFER_ENCODING:
                        stream.Write(TRANSFER_ENCODING_BYTES, 0, TRANSFER_ENCODING_BYTES.Length);
                        break;
                    case IF_NONE_MATCH:
                        stream.Write(IF_NONE_MATCH_BYTES, 0, IF_NONE_MATCH_BYTES.Length);
                        break;
                    default:
                        stream.Write(name + ": ");
                        break;
                }
            }

        }

        public static byte[] NULL_CONTENT_LENGTH_BYTES;

        public static byte[] CHUNKED_BYTES;

        public static byte[] LINE_BYTES;

        public static byte[] SPACE_BYTES;

        public static byte[] HEADER_SPLIT;

        public const string ACCEPT = "Accept";

        public static byte[] ACCEPT_BYTES;

        public const string ACCEPT_ENCODING = "Accept-Encoding";

        public static byte[] ACCEPT_ENCODING_BYTES;

        public const string ACCEPT_LANGUAGE = "Accept-Language";

        public static byte[] ACCEPT_LANGUAGE_BYTES;

        public const string CACHE_CONTROL = "Cache-Control";

        public static byte[] CACHE_CONTROL_BYTES;

        public const string CONNECTION = "Connection";

        public static byte[] CONNECTION_BYTES;

        public const string COOKIE = "Cookie";

        public static byte[] COOKIE_BYTES;

        public const string HOST = "Host";

        public static byte[] HOST_BYTE;

        public const string REFERER = "Referer";

        public static byte[] REFERER_BYTES;

        public const string USER_AGENT = "User-Agent";

        public static byte[] USER_AGENT_BYTES;

        public const string STATUS = "Status";

        public static byte[] STATUS_BYTES;

        public const string CONTENT_TYPE = "Content-Type";

        public static Byte[] CONTENT_TYPE_BYTES;

        public const string ETAG = "ETag";

        public static byte[] ETAG_BYTES;

        public const string CONTENT_LENGTH = "Content-Length";

        public static byte[] CONTENT_LENGTH_BYTES;

        public const string CONTENT_ENCODING = "Content-Encoding";

        public static byte[] CONTENT_ENCODING_BYTES;

        public const string TRANSFER_ENCODING = "Transfer-Encoding";

        public static byte[] TRANSFER_ENCODING_BYTES;

        public const string IF_NONE_MATCH = "If-None-Match";

        public static byte[] IF_NONE_MATCH_BYTES;

        public const string SERVER = "Server";

        public static byte[] SERVER_BYTES;

        public const string SET_COOKIE = "Set-Cookie";

        public static byte[] SET_COOKIE_BYTES;
    }

    public class Header
    {

        private Dictionary<string, string> mItems = new Dictionary<string, string>(16);

        public void Add(string name, string value)
        {
            mItems[name] = value;
        }
        public string this[string name]
        {
            get
            {
                string result = null;
                mItems.TryGetValue(name, out result);
                return result;
            }
            set
            {
                mItems[name] = value;
            }
        }

        public bool Read(PipeStream stream, Cookies cookies)
        {
            IndexOfResult index = stream.IndexOf(HeaderType.LINE_BYTES);
            while (index.End != null)
            {
                if (index.Length == 2)
                {
                    stream.ReadFree(2);
                    return true;
                }
                else
                {
                    ReadOnlySpan<Char> line = HttpParse.ReadCharLine(index);
                    stream.ReadFree(index.Length);
                    if (line[0] == 'C' && line[5] == 'e' && line[1] == 'o' && line[2] == 'o' && line[3] == 'k' && line[4] == 'i')
                    {
                        HttpParse.AnalyzeCookie(line.Slice(8, line.Length - 8), cookies);
                    }
                    else
                    {

                        Tuple<string, string> result = HttpParse.AnalyzeHeader(line);
                        Add(result.Item1, result.Item2);
                    }
                }
                index = stream.IndexOf(HeaderType.LINE_BYTES);
            }
            return false;
        }

        internal void Write(PipeStream stream)
        {
            foreach (var item in mItems)
            {
                HeaderType.Write(item.Key, stream);
                stream.Write(item.Value);
                stream.Write(HeaderType.LINE_BYTES, 0, 2);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in mItems)
            {
                sb.AppendFormat("{0}={1}\r\n", item.Key, item.Value);
            }
            return sb.ToString();
        }
    }


}
