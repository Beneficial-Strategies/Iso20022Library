// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the purpose of the securities account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y_Ex0dp-Ed-ak6NoX_4Aeg_965558025")]
[Description(@"Specifies the purpose of the securities account.")]
[Derivations(typeof(SecuritiesAccountPurposeType1Code))]
public enum SecuritiesAccountPurposeTypeCode
{
    /// <summary>
    /// Account is used when financing is done by the broker.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_Y_Ex0tp-Ed-ak6NoX_4Aeg_1289715496")]
    [Description(@"Account is used when financing is done by the broker.")]
    Margin,

    /// <summary>
    /// Account is used for short sale orders.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_Y_Ex09p-Ed-ak6NoX_4Aeg_1289715787")]
    [Description(@"Account is used for short sale orders.")]
    ShortSale,

    /// <summary>
    /// Account is located in a financial institution outside the country where the transaction is taking place.
    /// Encoded/decoded by serializers as &quot;ABRD&quot;.
    /// </summary>
    [EnumMember(Value = "ABRD")]
    [IsoId("_Y_Ex1Np-Ed-ak6NoX_4Aeg_1289715822")]
    [Description(
        @"Account is located in a financial institution outside the country where the transaction is taking place."
    )]
    Abroad,

    /// <summary>
    /// Account and all its related positions are held in one location.
    /// Encoded/decoded by serializers as &quot;CEND&quot;.
    /// </summary>
    [EnumMember(Value = "CEND")]
    [IsoId("_Y_Ex1dp-Ed-ak6NoX_4Aeg_1289715882")]
    [Description(@"Account and all its related positions are held in one location.")]
    Centralised,

    /// <summary>
    /// Account is used for settlement upon delivery, or a collection on a delivery basis.
    /// Encoded/decoded by serializers as &quot;DVPA&quot;.
    /// </summary>
    [EnumMember(Value = "DVPA")]
    [IsoId("_Y_Ex1tp-Ed-ak6NoX_4Aeg_1289715942")]
    [Description(
        @"Account is used for settlement upon delivery, or a collection on a delivery basis."
    )]
    CashDVP,

    /// <summary>
    /// Account is used for physical domestic safekeeping.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Y_Ex19p-Ed-ak6NoX_4Aeg_1289715977")]
    [Description(@"Account is used for physical domestic safekeeping.")]
    Physical,

    /// <summary>
    /// Financial instruments in the safekeeping account are fungible.
    /// Encoded/decoded by serializers as &quot;FUNG&quot;.
    /// </summary>
    [EnumMember(Value = "FUNG")]
    [IsoId("_45NmMdUeEeOz093LM8f3Hw")]
    [Description(@"Financial instruments in the safekeeping account are fungible.")]
    Fungible,

    /// <summary>
    /// Financial instruments in the safekeeping account are not fungible.
    /// Encoded/decoded by serializers as &quot;NFUN&quot;.
    /// </summary>
    [EnumMember(Value = "NFUN")]
    [IsoId("_7HTOYdUeEeOz093LM8f3Hw")]
    [Description(@"Financial instruments in the safekeeping account are not fungible.")]
    NonFungible,
}
