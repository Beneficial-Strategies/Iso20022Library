// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the geographic environment, or zone, in which a payment is executed, from the perspective of the forwarding or first agent, eg, international.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_auPCVNp-Ed-ak6NoX_4Aeg_-285785605")]
[Description(
    @"Specifies the geographic environment, or zone, in which a payment is executed, from the perspective of the forwarding or first agent, eg, international."
)]
public enum GeographicalEnvironmentCode
{
    /// <summary>
    /// Transaction has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DMST&quot;.
    /// </summary>
    [EnumMember(Value = "DMST")]
    [IsoId("_auPCVdp-Ed-ak6NoX_4Aeg_-285785604")]
    [Description(
        @"Transaction has an origin and a destination in the same country and is made in the currency of that country."
    )]
    Domestic,

    /// <summary>
    /// Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. Origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as &quot;EUDM&quot;.
    /// </summary>
    [EnumMember(Value = "EUDM")]
    [IsoId("_auPCVtp-Ed-ak6NoX_4Aeg_-285785603")]
    [Description(
        @"Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. Origin and destination countries may be one and the same country."
    )]
    EuroDomestic,

    /// <summary>
    /// Transaction is between a French Overseas Departments and Territories (Dom/Tom) and some country in the European Union (France included).
    /// Encoded/decoded by serializers as &quot;FRDT&quot;.
    /// </summary>
    [EnumMember(Value = "FRDT")]
    [IsoId("_OTgzNDE1-AOSNFX-8224503")]
    [Description(
        @"Transaction is between a French Overseas Departments and Territories (Dom/Tom) and some country in the European Union (France included)."
    )]
    FrenchDomTom,

    /// <summary>
    /// Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;INTL&quot;.
    /// </summary>
    [EnumMember(Value = "INTL")]
    [IsoId("_auYMQNp-Ed-ak6NoX_4Aeg_-285785601")]
    [Description(
        @"Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country."
    )]
    International,

    /// <summary>
    /// Transaction is a North American Free Trade Association (NAFTA) transaction, ie, the first and final agent are both located in the NAFTA area.
    /// Encoded/decoded by serializers as &quot;NFTA&quot;.
    /// </summary>
    [EnumMember(Value = "NFTA")]
    [IsoId("_auPCV9p-Ed-ak6NoX_4Aeg_-285785602")]
    [Description(
        @"Transaction is a North American Free Trade Association (NAFTA) transaction, ie, the first and final agent are both located in the NAFTA area."
    )]
    NAFTA,
}
