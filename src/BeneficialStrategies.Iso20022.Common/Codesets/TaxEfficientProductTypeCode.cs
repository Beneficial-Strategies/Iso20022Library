// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of tax efficient product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_X-nhUE4LEeiQHa-q1Uephw")]
[Description(@"Specifies a type of tax efficient product.")]
[Derivations(typeof(TaxEfficientProductType1Code),typeof(TaxEfficientProductType2Code))]
public enum TaxEfficientProductTypeCode
{
    /// <summary>
    /// Stocks and shares individual savings account. In the UK, this is known as a stocks and shares ISA.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_iN-RQE4LEeiQHa-q1Uephw")]
    [Description(@"Stocks and shares individual savings account. In the UK, this is known as a stocks and shares ISA.")]
    StocksAndShares,
    
    /// <summary>
    /// Junior stocks and shares individual savings account. In the UK, this is known as a stocks and shares  JISA.
    /// Encoded/decoded by serializers as &quot;JISA&quot;.
    /// </summary>
    [EnumMember(Value = "JISA")]
    [IsoId("_mkK1cE4LEeiQHa-q1Uephw")]
    [Description(@"Junior stocks and shares individual savings account. In the UK, this is known as a stocks and shares  JISA.")]
    JuniorStocksAndSharesISA,
    
    /// <summary>
    /// Stakeholder child trust fund individual savings account. In the UK, this is known as a stakeholder CTF ISA.
    /// Encoded/decoded by serializers as &quot;SCTF&quot;.
    /// </summary>
    [EnumMember(Value = "SCTF")]
    [IsoId("_rFcoQE4LEeiQHa-q1Uephw")]
    [Description(@"Stakeholder child trust fund individual savings account. In the UK, this is known as a stakeholder CTF ISA.")]
    StakeholderChildTrustFund,
    
    /// <summary>
    /// Cash individual savings account. In the UK, this is known as a cash ISA.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_uWMnUE4LEeiQHa-q1Uephw")]
    [Description(@"Cash individual savings account. In the UK, this is known as a cash ISA.")]
    Cash,
    
    /// <summary>
    /// Junior cash individual savings account. In the UK, this is known as a cash JISA.
    /// Encoded/decoded by serializers as &quot;JCSH&quot;.
    /// </summary>
    [EnumMember(Value = "JCSH")]
    [IsoId("_wlLnYE4LEeiQHa-q1Uephw")]
    [Description(@"Junior cash individual savings account. In the UK, this is known as a cash JISA.")]
    JuniorCash,
    
    /// <summary>
    /// Non-stakeholder child trust fund individual savings account. In the UK, this is known as a non-stakeholder CTF ISA.
    /// Encoded/decoded by serializers as &quot;CCTF&quot;.
    /// </summary>
    [EnumMember(Value = "CCTF")]
    [IsoId("_66P9wE4LEeiQHa-q1Uephw")]
    [Description(@"Non-stakeholder child trust fund individual savings account. In the UK, this is known as a non-stakeholder CTF ISA.")]
    NonStakeholderChildTrustFund,
    
    /// <summary>
    /// Stocks and shares lifetime individual savings account. In the UK, this is known as a stocks and shares LISA.
    /// Encoded/decoded by serializers as &quot;LISA&quot;.
    /// </summary>
    [EnumMember(Value = "LISA")]
    [IsoId("_ALOIIE4MEeiQHa-q1Uephw")]
    [Description(@"Stocks and shares lifetime individual savings account. In the UK, this is known as a stocks and shares LISA.")]
    Lifetime,
    
    /// <summary>
    /// Innovative finance individual savings account. In the UK, this is known as an innovative ISA.
    /// Encoded/decoded by serializers as &quot;INNF&quot;.
    /// </summary>
    [EnumMember(Value = "INNF")]
    [IsoId("_C4iqAE4MEeiQHa-q1Uephw")]
    [Description(@"Innovative finance individual savings account. In the UK, this is known as an innovative ISA.")]
    InnovativeFinance,
    
    /// <summary>
    /// Help to buy individual savings account. In the UK, this is known as a HISA.
    /// Encoded/decoded by serializers as &quot;HISA&quot;.
    /// </summary>
    [EnumMember(Value = "HISA")]
    [IsoId("_IcZ7ME4MEeiQHa-q1Uephw")]
    [Description(@"Help to buy individual savings account. In the UK, this is known as a HISA.")]
    HelpToBuy,
    
    /// <summary>
    /// Flexible individual savings account. In the UK, this is known as a FISA.
    /// Encoded/decoded by serializers as &quot;FISA&quot;.
    /// </summary>
    [EnumMember(Value = "FISA")]
    [IsoId("_LEYDAE4MEeiQHa-q1Uephw")]
    [Description(@"Flexible individual savings account. In the UK, this is known as a FISA.")]
    Flexible,
    
    /// <summary>
    /// General investment savings account. (Known as Investeringssparkonto (ISK) in some markets.)
    /// Encoded/decoded by serializers as &quot;GISK&quot;.
    /// </summary>
    [EnumMember(Value = "GISK")]
    [IsoId("__V6XgKFfEei_VZq-6SQkuQ")]
    [Description(@"General investment savings account. (Known as Investeringssparkonto (ISK) in some markets.)")]
    GeneralInvestmentSavingsAccount,
    
    /// <summary>
    /// General shares or equity savings account. (Known as ASK in some markets.)
    /// Encoded/decoded by serializers as &quot;GASK&quot;.
    /// </summary>
    [EnumMember(Value = "GASK")]
    [IsoId("_tmQZYKVFEeiYMvosZPzV4g")]
    [Description(@"General shares or equity savings account. (Known as ASK in some markets.)")]
    GeneralShareSavingsAccount,
    
    /// <summary>
    /// Cash lifetime individual savings account. In the UK, this is known as a cash LISA.
    /// Encoded/decoded by serializers as &quot;CLIS&quot;.
    /// </summary>
    [EnumMember(Value = "CLIS")]
    [IsoId("_etwKMJNtEemQB_8XA98K0Q")]
    [Description(@"Cash lifetime individual savings account. In the UK, this is known as a cash LISA.")]
    CashLISA,
    
}
