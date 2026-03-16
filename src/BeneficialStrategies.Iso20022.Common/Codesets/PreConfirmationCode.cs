// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if there is a pre-confirmation of cash or securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIFoUtp-Ed-ak6NoX_4Aeg_1034952016")]
[Description(@"Specifies if there is a pre-confirmation of cash or securities.")]
[Derivations(typeof(PreConfirmation1Code))]
public enum PreConfirmationCode
{
    /// <summary>
    /// Pre-confirmation of the movement of the cash, pending the movement of securities.
    /// Encoded/decoded by serializers as &quot;PRCA&quot;.
    /// </summary>
    [EnumMember(Value = "PRCA")]
    [IsoId("_aIFoU9p-Ed-ak6NoX_4Aeg_-1927375439")]
    [Description(
        @"Pre-confirmation of the movement of the cash, pending the movement of securities."
    )]
    PreConfirmCash,

    /// <summary>
    /// Pre-confirmation of the movement of the securities, pending the movement of cash.
    /// Encoded/decoded by serializers as &quot;PRSE&quot;.
    /// </summary>
    [EnumMember(Value = "PRSE")]
    [IsoId("_aIFoVNp-Ed-ak6NoX_4Aeg_-1628151846")]
    [Description(
        @"Pre-confirmation of the movement of the securities, pending the movement of cash."
    )]
    PreConfirmSecurities,
}
