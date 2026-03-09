// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the financial instrument reporting classification for both equity and non-equity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__esiMPPQEeS_qLctCs2aRQ")]
[Description(@"Specifies the financial instrument reporting classification for both equity and non-equity.")]
[Derivations(typeof(NonEquityInstrumentReportingClassification1Code),typeof(EquityInstrumentReportingClassification1Code))]
public enum FinancialInstrumentReportingClassificationCode
{
    /// <summary>
    /// Contract is of type securitised derivatives.
    /// Encoded/decoded by serializers as &quot;SDRV&quot;.
    /// </summary>
    [EnumMember(Value = "SDRV")]
    [IsoId("_DSY2QPPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type securitised derivatives.")]
    SecuritisedDerivative,
    
    /// <summary>
    /// Contract is of type structured finance products (SFPs).
    /// Encoded/decoded by serializers as &quot;SFPS&quot;.
    /// </summary>
    [EnumMember(Value = "SFPS")]
    [IsoId("_HLvGYfPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type structured finance products (SFPs).")]
    StructuredFinanceProduct,
    
    /// <summary>
    /// Contract is of type bonds.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_IBJEYfPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type bonds.|")]
    Bond,
    
    /// <summary>
    /// Contract is of type emission allowances.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_IYM5gfPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type emission allowances.")]
    EmissionAllowance,
    
    /// <summary>
    /// Contract is of type contract for difference (CFD).
    /// Encoded/decoded by serializers as &quot;CFDS&quot;.
    /// </summary>
    [EnumMember(Value = "CFDS")]
    [IsoId("_K1KEIfPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type contract for difference (CFD).|")]
    ContractForDifference,
    
    /// <summary>
    /// Contract is of type derivative.
    /// Encoded/decoded by serializers as &quot;DERV&quot;.
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_LLeSYfPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type derivative.|")]
    Derivative,
    
    /// <summary>
    /// Contract is of type shares.
    /// Encoded/decoded by serializers as &quot;SHRS&quot;.
    /// </summary>
    [EnumMember(Value = "SHRS")]
    [IsoId("_cna1oAjqEeW36pGcc5RpFw")]
    [Description(@"Contract is of type shares.")]
    Share,
    
    /// <summary>
    /// Contract is of type electronic traded funds.
    /// Encoded/decoded by serializers as &quot;ETFS&quot;.
    /// </summary>
    [EnumMember(Value = "ETFS")]
    [IsoId("_hr5cIAjqEeW36pGcc5RpFw")]
    [Description(@"Contract is of type electronic traded funds.")]
    ElectronicTradedFund,
    
    /// <summary>
    /// Contract is of type depositary receipt.
    /// Encoded/decoded by serializers as &quot;DPRS&quot;.
    /// </summary>
    [EnumMember(Value = "DPRS")]
    [IsoId("_oxp94AjqEeW36pGcc5RpFw")]
    [Description(@"Contract is of type depositary receipt.")]
    DepositaryReceipt,
    
    /// <summary>
    /// Contract is of type other equity-like financial instrument.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_zYziwAjqEeW36pGcc5RpFw")]
    [Description(@"Contract is of type other equity-like financial instrument.")]
    Other,
    
    /// <summary>
    /// Contract is of type certificates.
    /// Encoded/decoded by serializers as &quot;CRFT&quot;.
    /// </summary>
    [EnumMember(Value = "CRFT")]
    [IsoId("_zY9TwAjqEeW36pGcc5RpFw")]
    [Description(@"Contract is of type certificates.")]
    Certificate,
    
    /// <summary>
    /// Contract is of type exchange traded note.
    /// Encoded/decoded by serializers as &quot;ETNS&quot;.
    /// </summary>
    [EnumMember(Value = "ETNS")]
    [IsoId("_2_VMYAnNEeW1sbwBDSZgiA")]
    [Description(@"Contract is of type exchange traded note.")]
    ExchangeTradedNote,
    
    /// <summary>
    /// Contract is of type exchange traded commodities.
    /// Encoded/decoded by serializers as &quot;ETCS&quot;.
    /// </summary>
    [EnumMember(Value = "ETCS")]
    [IsoId("_6zeMYAnNEeW1sbwBDSZgiA")]
    [Description(@"Contract is of type exchange traded commodities.")]
    ExchangeTradedCommodities,
    
}
