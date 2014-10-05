using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.MemoryMappedFiles;

namespace iRSDKSharp
{
    public class CiRSDKHeader
    {
        //Header offsets
        public const int HVerOffset = 0;
        public const int HStatusOffset = 4;
        public const int HTickRateOffset = 8;
        public const int HSesInfoUpdateOffset = 12;
        public const int HSesInfoLenOffset = 16;
        public const int HSesInfoOffsetOffset = 20;
        public const int HNumVarsOffset = 24;
        public const int HVarHeaderOffsetOffset = 28;
        public const int HNumBufOffset = 32;
        public const int HBufLenOffset = 36;

        private int _LineNumberMax = -1;
        public int LineNumberMax
        {
            get { return _LineNumberMax; }
            set { _LineNumberMax = value; }
        }
        public int LineNumber { get; set; }

        MemoryMappedViewAccessor FileMapView = null;

        CVarBuf buffer = null;

        public CiRSDKHeader(MemoryMappedViewAccessor mapView)
        {
            FileMapView = mapView;
            buffer = new CVarBuf(mapView, this);
        }

        public int Version
        {
            get { return FileMapView.ReadInt32(HVerOffset); }
        }

        public int Status
        {
            get { return FileMapView.ReadInt32(HStatusOffset); }
        }

        public int TickRate
        {
            get { return FileMapView.ReadInt32(HTickRateOffset); }
        }

        public int SessionInfoUpdate
        {
            get { return FileMapView.ReadInt32(HSesInfoUpdateOffset); }
        }

        public int SessionInfoLength
        {
            get { return FileMapView.ReadInt32(HSesInfoLenOffset); }
        }

        public int SessionInfoOffset
        {
            get { return FileMapView.ReadInt32(HSesInfoOffsetOffset); }
        }

        public int VarCount
        {
            get { return FileMapView.ReadInt32(HNumVarsOffset); }
        }

        public int VarHeaderOffset
        {
            get { return FileMapView.ReadInt32(HVarHeaderOffsetOffset); }
        }

        public int BufferCount
        {
            get { return FileMapView.ReadInt32(HNumBufOffset); }
        }

        public int BufferLength
        {
            get { return FileMapView.ReadInt32(HBufLenOffset); }
        }

        public int Buffer
        {
            get
            {
                return buffer.OffsetLatest + (LineNumber * BufferLength);
            }
        }

        public int StreamPosition
        {
            get
            {
                return buffer.OffsetLatest + (LineNumber * BufferLength);
            }
        }

        public bool IsEOF
        {
            get
            {
                return
                        (LineNumberMax > -1 && LineNumber >= LineNumberMax)//ideal scenario
                        || (StreamPosition + BufferLength > FileMapView.Capacity);//fallback scenario
            }
        }
    }
}
