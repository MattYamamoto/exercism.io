using System;

public class SimpleCipher
{
    public SimpleCipher()
    {
        this._key = RandomKey(100);
    }

    public SimpleCipher(string key)
    {
        this._key = key;
    }

    private string _key;
    public string Key
    {
        get
        {
            return this._key.ToLower();
        }
    }

    private string RandomKey(int keyLength)
    {
        Random random = new Random();

        string key = "";
        for (int i = 1; i <= keyLength; i++)
        {
            key += (char)('a' + (char)random.Next(0, 26));
        }

        return key;
    }

    public string Encode(string plaintext)
    {
        string ciphertext = "";
        int shift;

        for (int i = 0; i < plaintext.Length; i++)
        {
            shift = Key[i % Key.Length] - 'a';
            ciphertext += ShiftCharacter(plaintext[i], shift);
        }

        return ciphertext;
    }

    private char ShiftCharacter(char letter, int distance)
    {
        int baseIndex = (int)'a';
        int startIndex = letter - 'a';
        int shiftToIndex = (startIndex + distance) % 26;

        if (shiftToIndex < 0) shiftToIndex = shiftToIndex + 26;

        return (char)(baseIndex + shiftToIndex);
    }

    public string Decode(string ciphertext)
    {
        string plaintext = "";
        int shift;

        for (int i = 0; i < ciphertext.Length; i++)
        {
            shift = Key[i % Key.Length] - 'a';
            plaintext += ShiftCharacter(ciphertext[i], -1 * shift);
        }

        return plaintext;
    }
}