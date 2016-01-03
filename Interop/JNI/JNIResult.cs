namespace DroidSharp.Interop.JNI
{
    internal enum JNIResult : int
    {
        Ok = 0,
        Error = -1,
        ThreadDetachedError = -2,
        VersionError = -3
    }
}
