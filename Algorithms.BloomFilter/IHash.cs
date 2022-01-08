using System.Security.Cryptography;

namespace Algorithms.BloomFilter
{
    public interface IHash
    {
        uint Compute(HashKey key);
    }

    public class Hash : IHash
    {
        HashAlgorithm _algo;
        public Hash(HashAlgorithm algo)
        {
            _algo = algo;
        }

        public uint Compute(HashKey key)
        {
            return BitConverter.ToUInt32(_algo.ComputeHash(key.ToBytes()), 0);
        }
    }
}
