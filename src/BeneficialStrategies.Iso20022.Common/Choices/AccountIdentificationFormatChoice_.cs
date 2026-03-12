// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for account identification.
    /// </summary>
    [KnownType(typeof(AccountIdentificationFormatChoice.SimpleIdentification))]
    [KnownType(typeof(AccountIdentificationFormatChoice.IdentificationAndPurpose))]
    [KnownType(typeof(AccountIdentificationFormatChoice.IdentificationAsDSS))]
    [JsonDerivedType(typeof(AccountIdentificationFormatChoice.SimpleIdentification),nameof(AccountIdentificationFormatChoice.SimpleIdentification))]
    [JsonDerivedType(typeof(AccountIdentificationFormatChoice.IdentificationAndPurpose),nameof(AccountIdentificationFormatChoice.IdentificationAndPurpose))]
    [JsonDerivedType(typeof(AccountIdentificationFormatChoice.IdentificationAsDSS),nameof(AccountIdentificationFormatChoice.IdentificationAsDSS))]
    [IsoId("_RBvu5dp-Ed-ak6NoX_4Aeg_1713990380")]
    [DisplayName("Account Identification Format Choice")]
    public abstract partial record AccountIdentificationFormatChoice_
    {
    }
}
