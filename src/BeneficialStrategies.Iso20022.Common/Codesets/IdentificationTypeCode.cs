// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of identification of the party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2G4usEVPEeSGWeX3z5zSZQ")]
[Description(@"Indicates the type of identification of the party.")]
[Derivations(typeof(IdentificationType2Code),typeof(IdentificationType1Code))]
public enum IdentificationTypeCode
{
    /// <summary>
    /// BIC code defines as a standard format of business identifier code. It is a unique identification code for both financial and non-financial institutions.
    /// Encoded/decoded by serializers as &quot;BICO&quot;.
    /// </summary>
    [EnumMember(Value = "BICO")]
    [IsoId("_G-8Q8EVQEeSGWeX3z5zSZQ")]
    [Description(@"BIC code defines as a standard format of business identifier code. It is a unique identification code for both financial and non-financial institutions.")]
    BIC,
    
    /// <summary>
    /// Specified source is bank.
    /// Encoded/decoded by serializers as &quot;BASC&quot;.
    /// </summary>
    [EnumMember(Value = "BASC")]
    [IsoId("_JEZhkEVQEeSGWeX3z5zSZQ")]
    [Description(@"Specified source is bank.")]
    BankSortCode,
    
    /// <summary>
    /// CFETS is an abbreviation of China Foreign Exchange Trade System, which is a sub-institution of the PBC. Its main functions include: providing systems for FX trading, RMB lending, bond trading and exchange rate and interest rate derivatives trading; organizing FX trading, RMB lending, bond trading, and exchange rate and interest rate derivatives trading; providing clearing, information, risk management, and surveillance services on interbank markets; and engaging in other businesses authorized by the PBC.
    /// Encoded/decoded by serializers as &quot;CFET&quot;.
    /// </summary>
    [EnumMember(Value = "CFET")]
    [IsoId("_Kzh84EVQEeSGWeX3z5zSZQ")]
    [Description(@"CFETS is an abbreviation of China Foreign Exchange Trade System, which is a sub-institution of the PBC. Its main functions include: providing systems for FX trading, RMB lending, bond trading and exchange rate and interest rate derivatives trading; organizing FX trading, RMB lending, bond trading, and exchange rate and interest rate derivatives trading; providing clearing, information, risk management, and surveillance services on interbank markets; and engaging in other businesses authorized by the PBC.")]
    CFETS,
    
    /// <summary>
    /// CDC is an abbreviation of China Central Depository &amp; Clearing Co, Ltd, an entity undertake functions of centralized depository and settlement for inter-bank bond market in China.
    /// Encoded/decoded by serializers as &quot;CDCO&quot;.
    /// </summary>
    [EnumMember(Value = "CDCO")]
    [IsoId("_21BjQIA4EeSUJZYcWGKkkw")]
    [Description(@"CDC is an abbreviation of China Central Depository & Clearing Co, Ltd, an entity undertake functions of centralized depository and settlement for inter-bank bond market in China.")]
    CDC,
    
    /// <summary>
    /// RIC Code is an abbreviation of Reuters Instrument Code. RIC as encoding rule which has been wildly adopted in FX market and defines information including trading category, tenor, trade instrument and so on.
    /// Encoded/decoded by serializers as &quot;RICC&quot;.
    /// </summary>
    [EnumMember(Value = "RICC")]
    [IsoId("_28utwIA4EeSUJZYcWGKkkw")]
    [Description(@"RIC Code is an abbreviation of Reuters Instrument Code. RIC as encoding rule which has been wildly adopted in FX market and defines information including trading category, tenor, trade instrument and so on.")]
    RICCode,
    
    /// <summary>
    /// User defined code.
    /// Encoded/decoded by serializers as &quot;USDE&quot;.
    /// </summary>
    [EnumMember(Value = "USDE")]
    [IsoId("_3B_oQIA4EeSUJZYcWGKkkw")]
    [Description(@"User defined code.")]
    UserDefined,
    
}
