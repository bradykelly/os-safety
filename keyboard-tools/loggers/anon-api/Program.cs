using Keystroke.API;

using var api = new KeystrokeAPI();
api.CreateKeyboardHook(Console.Write);
