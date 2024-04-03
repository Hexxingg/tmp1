namespace LinUpgrade.PeakLinBus
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    public class PLinApi
    {
        public const byte INVALID_LIN_HANDLE = 0;
        [Obsolete]
        public const byte LIN_HW_TYPE_USB = 1;
        public const byte LIN_HW_TYPE_USB_PRO = 1;
        public const byte LIN_HW_TYPE_USB_PRO_FD = 2;
        public const byte LIN_HW_TYPE_PLIN_USB = 3;
        public const byte LIN_MAX_FRAME_ID = 0x3f;
        public const int LIN_MAX_SCHEDULES = 8;
        public const int LIN_MIN_SCHEDULE_NUMBER = 0;
        public const int LIN_MAX_SCHEDULE_NUMBER = 7;
        public const int LIN_MAX_SCHEDULE_SLOTS = 0x100;
        public const ushort LIN_MIN_BAUDRATE = 0x3e8;
        public const ushort LIN_MAX_BAUDRATE = 0x4e20;
        public const ushort LIN_MAX_NAME_LENGTH = 0x30;
        public const int FRAME_FLAG_RESPONSE_ENABLE = 1;
        public const int FRAME_FLAG_SINGLE_SHOT = 2;
        public const int FRAME_FLAG_IGNORE_INIT_DATA = 4;
        public const int LIN_MAX_USER_DATA = 0x18;
        public const int LIN_MIN_BREAK_LENGTH = 13;
        public const int LIN_MAX_BREAK_LENGTH = 0x20;

        [DllImport("plinapi.dll", EntryPoint = "LIN_CalculateChecksum")]
        public static extern TLINError CalculateChecksum(ref TLINMsg pMsg);
        [DllImport("plinapi.dll", EntryPoint = "LIN_ConnectClient")]
        public static extern TLINError ConnectClient(byte hClient, ushort hHw);
        [DllImport("plinapi.dll", EntryPoint = "LIN_DeleteSchedule")]
        public static extern TLINError DeleteSchedule(byte hClient, ushort hHw, int iScheduleNumber);
        [DllImport("plinapi.dll", EntryPoint = "LIN_DisconnectClient")]
        public static extern TLINError DisconnectClient(byte hClient, ushort hHw);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetAvailableHardware")]
        public static extern TLINError GetAvailableHardware([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] pBuff, ushort wBuffSize, out ushort pCount);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetClientFilter")]
        public static extern TLINError GetClientFilter(byte hClient, ushort hHw, [MarshalAs(UnmanagedType.I8)] out ulong pRcvMask);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetClientParam")]
        public static extern TLINError GetClientParam(byte hClient, TLINClientParam wParam, out int pBuff, ushort wBuffSize);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetClientParam")]
        public static extern TLINError GetClientParam(byte hClient, TLINClientParam wParam, [MarshalAs(UnmanagedType.LPStr)] StringBuilder pBuff, ushort wBuffSize);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetClientParam")]
        public static extern TLINError GetClientParam(byte hClient, TLINClientParam wParam, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] pBuff, ushort wBuffSize);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetErrorText")]
        public static extern TLINError GetErrorText(TLINError dwError, byte bLanguage, [MarshalAs(UnmanagedType.LPStr)] StringBuilder strTextBuff, int wBuffSize);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetFrameEntry")]
        public static extern TLINError GetFrameEntry(ushort hHw, ref TLINFrameEntry pFrameEntry);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetHardwareParam")]
        public static extern TLINError GetHardwareParam(ushort hHw, TLINHardwareParam wParam, [MarshalAs(UnmanagedType.LPStr)] StringBuilder pBuff, ushort wBuffLen);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetHardwareParam")]
        public static extern TLINError GetHardwareParam(ushort hHw, TLINHardwareParam wParam, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] pBuff, ushort wBuffLen);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetHardwareParam")]
        public static extern TLINError GetHardwareParam(ushort hHw, TLINHardwareParam wParam, out TLINVersion pBuff, ushort wBuffLen);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetHardwareParam")]
        public static extern TLINError GetHardwareParam(ushort hHw, TLINHardwareParam wParam, out byte pBuff, ushort wBuffLen);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetHardwareParam")]
        public static extern TLINError GetHardwareParam(ushort hHw, TLINHardwareParam wParam, out int pBuff, ushort wBuffSize);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetHardwareParam")]
        public static extern TLINError GetHardwareParam(ushort hHw, TLINHardwareParam wParam, out ulong pBuff, ushort wBuffLen);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetPID")]
        public static extern TLINError GetPID(ref byte pFrameId);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetResponseRemap")]
        public static extern TLINError GetResponseRemap(ushort hHw, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0, SizeConst = 0x40)] byte[] pRemapTab);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetSchedule")]
        public static extern TLINError GetSchedule(ushort hHw, int iScheduleNumber, [In, Out] TLINScheduleSlot[] pScheduleBuff, int iMaxSlotCount, out int pSlotCount);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetStatus")]
        public static extern TLINError GetStatus(ushort hHw, out TLINHardwareStatus pStatusBuff);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetSystemTime")]
        public static extern TLINError GetSystemTime(out ulong pTargetTime);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetTargetTime")]
        public static extern TLINError GetTargetTime(ushort hHw, out ulong pTargetTime);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetVersion")]
        public static extern TLINError GetVersion(ref TLINVersion pVerBuffer);
        [DllImport("plinapi.dll", EntryPoint = "LIN_GetVersionInfo")]
        public static extern TLINError GetVersionInfo([MarshalAs(UnmanagedType.LPStr)] StringBuilder pTextBuff, int wBuffSize);
        [DllImport("plinapi.dll", EntryPoint = "LIN_IdentifyHardware")]
        public static extern TLINError IdentifyHardware(ushort hHw);
        [DllImport("plinapi.dll", EntryPoint = "LIN_InitializeHardware")]
        public static extern TLINError InitializeHardware(byte hClient, ushort hHw, [MarshalAs(UnmanagedType.U1)] TLINHardwareMode byMode, ushort wBaudrate);
        [DllImport("plinapi.dll", EntryPoint = "LIN_Read")]
        public static extern TLINError Read(byte hClient, out TLINRcvMsg pMsg);
        [DllImport("plinapi.dll", EntryPoint = "LIN_ReadMulti")]
        public static extern TLINError ReadMulti(byte hClient, [In, Out] TLINRcvMsg[] pMsgBuff, int iMaxCount, out int pCount);
        [DllImport("plinapi.dll", EntryPoint = "LIN_RegisterClient")]
        public static extern TLINError RegisterClient(string strName, IntPtr hWnd, out byte hClient);
        [DllImport("plinapi.dll", EntryPoint = "LIN_RegisterFrameId")]
        public static extern TLINError RegisterFrameId(byte hClient, ushort hHw, byte bFromFrameId, byte bToFrameId);
        [DllImport("plinapi.dll", EntryPoint = "LIN_RemoveClient")]
        public static extern TLINError RemoveClient(byte hClient);
        [DllImport("plinapi.dll", EntryPoint = "LIN_ResetClient")]
        public static extern TLINError ResetClient(byte hClient);
        [DllImport("plinapi.dll", EntryPoint = "LIN_ResetHardware")]
        public static extern TLINError ResetHardware(byte hClient, ushort hHw);
        [DllImport("plinapi.dll", EntryPoint = "LIN_ResetHardwareConfig")]
        public static extern TLINError ResetHardwareConfig(byte hClient, ushort hHw);
        [DllImport("plinapi.dll", EntryPoint = "LIN_ResumeKeepAlive")]
        public static extern TLINError ResumeKeepAlive(byte hClient, ushort hHw);
        [DllImport("plinapi.dll", EntryPoint = "LIN_ResumeSchedule")]
        public static extern TLINError ResumeSchedule(byte hClient, ushort hHw);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SetClientFilter")]
        public static extern TLINError SetClientFilter(byte hClient, ushort hHw, [MarshalAs(UnmanagedType.I8)] ulong iRcvMask);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SetClientParam")]
        public static extern TLINError SetClientParam(byte hClient, TLINClientParam wParam, int dwValue);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SetFrameEntry")]
        public static extern TLINError SetFrameEntry(byte hClient, ushort hHw, ref TLINFrameEntry pFrameEntry);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SetHardwareParam")]
        public static extern TLINError SetHardwareParam(byte hClient, ushort hHw, TLINHardwareParam wParam, ref byte pBuff, ushort wBuffSize);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SetHardwareParam")]
        public static extern TLINError SetHardwareParam(byte hClient, ushort hHw, TLINHardwareParam wParam, ref int pBuff, ushort wBuffSize);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SetHardwareParam")]
        public static extern TLINError SetHardwareParam(byte hClient, ushort hHw, TLINHardwareParam wParam, ref ulong pBuff, ushort wBuffSize);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SetHardwareParam")]
        public static extern TLINError SetHardwareParam(byte hClient, ushort hHw, TLINHardwareParam wParam, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] pBuff, ushort wBuffSize);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SetResponseRemap")]
        public static extern TLINError SetResponseRemap(byte hClient, ushort hHw, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0, SizeConst = 0x40)] byte[] pRemapTab);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SetSchedule")]
        public static extern TLINError SetSchedule(byte hClient, ushort hHw, int iScheduleNumber, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] TLINScheduleSlot[] pSchedule, int iSlotCount);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SetScheduleBreakPoint")]
        public static extern TLINError SetScheduleBreakPoint(byte hClient, ushort hHw, int iBreakPointNumber, uint dwHandle);
        [DllImport("plinapi.dll", EntryPoint = "LIN_StartAutoBaud")]
        public static extern TLINError StartAutoBaud(byte hClient, ushort hHw, ushort wTimeOut);
        [DllImport("plinapi.dll", EntryPoint = "LIN_StartKeepAlive")]
        public static extern TLINError StartKeepAlive(byte hClient, ushort hHw, byte bFrameId, ushort wPeriod);
        [DllImport("plinapi.dll", EntryPoint = "LIN_StartSchedule")]
        public static extern TLINError StartSchedule(byte hClient, ushort hHw, int iScheduleNumber);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SuspendKeepAlive")]
        public static extern TLINError SuspendKeepAlive(byte hClient, ushort hHw);
        [DllImport("plinapi.dll", EntryPoint = "LIN_SuspendSchedule")]
        public static extern TLINError SuspendSchedule(byte hClient, ushort hHw);
        [DllImport("plinapi.dll", EntryPoint = "LIN_UpdateByteArray")]
        public static extern TLINError UpdateByteArray(byte hClient, ushort hHw, byte bFrameId, byte bIndex, byte bLen, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] pData);
        [DllImport("plinapi.dll", EntryPoint = "LIN_Write")]
        public static extern TLINError Write(byte hClient, ushort hHw, ref TLINMsg pMsg);
        [DllImport("plinapi.dll", EntryPoint = "LIN_XmtWakeUp")]
        public static extern TLINError XmtWakeUp(byte hClient, ushort hHw);
    }
}

