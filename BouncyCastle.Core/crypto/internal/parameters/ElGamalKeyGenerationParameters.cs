using System;

using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Internal.Parameters
{
    internal class ElGamalKeyGenerationParameters
		: KeyGenerationParameters
    {
        private readonly DHParameters parameters;

		public ElGamalKeyGenerationParameters(
            SecureRandom		random,
            DHParameters	parameters)
			: base(random, GetStrength(parameters))
        {
            this.parameters = parameters;
        }

		public DHParameters Parameters
        {
            get { return parameters; }
        }

		internal static int GetStrength(
			DHParameters parameters)
		{
			return parameters.L != 0 ? parameters.L : parameters.P.BitLength;
		}
    }
}
