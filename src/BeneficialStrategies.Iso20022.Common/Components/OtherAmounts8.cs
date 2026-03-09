// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies other amounts pertaining to the transaction.
/// </summary>
[IsoId("_9q6Y4dz1Ed-a791rB7tZXQ")]
[DisplayName("Other Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherAmounts8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_9q6Y49z1Ed-a791rB7tZXQ")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection23? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_9q6Y5dz1Ed-a791rB7tZXQ")]
    [DisplayName("Charges Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsFees")]
    #endif
    [IsoXmlTag("ChrgsFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? ChargesFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? ChargesFees { get; init; } 
    #else
    public AmountAndDirection23? ChargesFees { get; set; } 
    #endif
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_9q6Y6dz1Ed-a791rB7tZXQ")]
    [DisplayName("Trade Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradAmt")]
    #endif
    [IsoXmlTag("TradAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? TradeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? TradeAmount { get; init; } 
    #else
    public AmountAndDirection23? TradeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_9q6Y69z1Ed-a791rB7tZXQ")]
    [DisplayName("Executing Broker Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctgBrkrAmt")]
    #endif
    [IsoXmlTag("ExctgBrkrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? ExecutingBrokerAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? ExecutingBrokerAmount { get; init; } 
    #else
    public AmountAndDirection23? ExecutingBrokerAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_9q6Y8dz1Ed-a791rB7tZXQ")]
    [DisplayName("Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTax")]
    #endif
    [IsoXmlTag("LclTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? LocalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? LocalTax { get; init; } 
    #else
    public AmountAndDirection23? LocalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_9q6Y89z1Ed-a791rB7tZXQ")]
    [DisplayName("Local Broker Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclBrkrComssn")]
    #endif
    [IsoXmlTag("LclBrkrComssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? LocalBrokerCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? LocalBrokerCommission { get; init; } 
    #else
    public AmountAndDirection23? LocalBrokerCommission { get; set; } 
    #endif
    
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_9q6Y99z1Ed-a791rB7tZXQ")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? Other { get; init; } 
    #else
    public AmountAndDirection23? Other { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_9q6ZAdz1Ed-a791rB7tZXQ")]
    [DisplayName("Stamp Duty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDty")]
    #endif
    [IsoXmlTag("StmpDty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? StampDuty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? StampDuty { get; init; } 
    #else
    public AmountAndDirection23? StampDuty { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_9q6ZB9z1Ed-a791rB7tZXQ")]
    [DisplayName("Transaction Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTax")]
    #endif
    [IsoXmlTag("TxTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? TransactionTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? TransactionTax { get; init; } 
    #else
    public AmountAndDirection23? TransactionTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_9q6ZC9z1Ed-a791rB7tZXQ")]
    [DisplayName("Withholding Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTax")]
    #endif
    [IsoXmlTag("WhldgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? WithholdingTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? WithholdingTax { get; init; } 
    #else
    public AmountAndDirection23? WithholdingTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_9q6ZD9z1Ed-a791rB7tZXQ")]
    [DisplayName("Consumption Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CsmptnTax")]
    #endif
    [IsoXmlTag("CsmptnTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection23? ConsumptionTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection23? ConsumptionTax { get; init; } 
    #else
    public AmountAndDirection23? ConsumptionTax { get; set; } 
    #endif
    
    
    #nullable disable
    
}
