// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters3Choice
{
    /// <summary>
    /// Parameters to be used by the various cryptographic key commands.
    /// </summary>
    [IsoId("_htqcO12aEeekzJIz1JxYSQ")]
    [DisplayName("Key")]
    public record Key : ATMCommandParameters3Choice_
    {
        /// <summary>
        /// Category of the cryptographic key.
        /// </summary>
        [IsoId("_T5qOQItJEeSxlKlAGYErFg")]
        [DisplayName("Key Category")]
        [IsoXmlTag("KeyCtgy")]
        public CryptographicKeyType4Code? KeyCategory { get; init; }

        /// <summary>
        /// Random value from the host provided during a previous exchange.
        /// </summary>
        [IsoId("_hkcjQItJEeSxlKlAGYErFg")]
        [DisplayName("Host Challenge")]
        [IsoXmlTag("HstChllng")]
        [IsoSimpleType(IsoSimpleType.Max140Binary)]
        public IsoMax140Binary? HostChallenge { get; init; }

        /// <summary>
        /// Ordered certificate chain of the asymmetric key encryption key, starting with the host certificate.
        /// </summary>
        [IsoId("_tNm-wItJEeSxlKlAGYErFg")]
        [DisplayName("Certificate")]
        [IsoXmlTag("Cert")]
        [IsoSimpleType(IsoSimpleType.Max5000Binary)]
        public IsoMax5000Binary? Certificate { get; init; }

        /// <summary>
        /// Cryptographic key involved in the security command.
        /// </summary>
        [IsoId("_ABCokItKEeSxlKlAGYErFg")]
        [DisplayName("Key Properties")]
        [IsoXmlTag("KeyProps")]
        public KEKIdentifier4? KeyProperties { get; init; }
    }
}
