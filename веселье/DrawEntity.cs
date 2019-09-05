static void DrawEntity(int ClowIndex, int red, int green, int blue)
{
    int GlowObhect = mem.Read<int>(/*The path or signature of the object, you want to highlight or shine.*/);
    mem.Write<float>(GlowObhect + (ClowIndex * 0x38) + 0x4, red / 100);
    mem.Write<float>(GlowObhect + (ClowIndex * 0x38) + 0x8, green / 100);
    mem.Write<float>(GlowObhect + (ClowIndex * 0x38) + 0xC, blue / 100);
    mem.Write<float>(GlowObhect + (ClowIndex * 0x38) + 0x10, 255 / 100);
    mem.Write<bool>(GlowObhect + (ClowIndex * 0x38) + 0x24, true);
    mem.Write<bool>(GlowObhect + (ClowIndex * 0x38) + 0x25, false);
}
