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
/// Defines the criteria which are used to search for standing orders defined within the system.
/// </summary>
[IsoId("_jE-P6ZlPEee-Zps0fZQaFQ")]
[DisplayName("Standing Order Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StandingOrderSearchCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the key fields or business attributes defined within the system must be returned.
    /// </summary>
    [IsoId("_jNAKgZlPEee-Zps0fZQaFQ")]
    [DisplayName("Key Attributes Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyAttrbtsInd")]
    #endif
    [IsoXmlTag("KeyAttrbtsInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? KeyAttributesIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? KeyAttributesIndicator { get; init; } 
    #else
    public System.String? KeyAttributesIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to unambiguously identify the standing order used to initiate the liquidity transfer.
    /// </summary>
    [IsoId("_jNAKg5lPEee-Zps0fZQaFQ")]
    [DisplayName("Standing Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdrId")]
    #endif
    [IsoXmlTag("StgOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? StandingOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StandingOrderIdentification { get; init; } 
    #else
    public System.String? StandingOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the standing order.
    /// </summary>
    [IsoId("_jNAKhZlPEee-Zps0fZQaFQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StandingOrderType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrderType1Choice_? Type { get; init; } 
    #else
    public StandingOrderType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
    /// </summary>
    [IsoId("_jNAKh5lPEee-Zps0fZQaFQ")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? Account { get; init; } 
    #else
    public CashAccount24? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
    /// </summary>
    [IsoId("_jNAKiZlPEee-Zps0fZQaFQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Dates during which the standing order is in effect.
    /// </summary>
    [IsoId("_jNAKi5lPEee-Zps0fZQaFQ")]
    [DisplayName("Validity Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyPrd")]
    #endif
    [IsoXmlTag("VldtyPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriod2Choice_? ValidityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod2Choice_? ValidityPeriod { get; init; } 
    #else
    public DatePeriod2Choice_? ValidityPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the account is debited or credited by the standing order.
    /// </summary>
    [IsoId("_jNAKjZlPEee-Zps0fZQaFQ")]
    [DisplayName("System Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysMmb")]
    #endif
    [IsoXmlTag("SysMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? SystemMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? SystemMember { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? SystemMember { get; set; } 
    #endif
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_jNAKj5lPEee-Zps0fZQaFQ")]
    [DisplayName("Responsible Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnsblPty")]
    #endif
    [IsoXmlTag("RspnsblPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? ResponsibleParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? ResponsibleParty { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? ResponsibleParty { get; set; } 
    #endif
    
    /// <summary>
    /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
    /// </summary>
    [IsoId("_jNAKkZlPEee-Zps0fZQaFQ")]
    [DisplayName("Associated Pool Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdPoolAcct")]
    #endif
    [IsoXmlTag("AssoctdPoolAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; } 
    #else
    public AccountIdentification4Choice_? AssociatedPoolAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to unambiguously identify the link set in which the standing order is defined. The link set is a collection of standing order defined in a specific sequence.
    /// </summary>
    [IsoId("_jNAKk5lPEee-Zps0fZQaFQ")]
    [DisplayName("Link Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkSetId")]
    #endif
    [IsoXmlTag("LkSetId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LinkSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LinkSetIdentification { get; init; } 
    #else
    public System.String? LinkSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to unambiguously identify liquidity transfer standing order within the link set.
    /// </summary>
    [IsoId("_jNAKlZlPEee-Zps0fZQaFQ")]
    [DisplayName("Link Set Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkSetOrdrId")]
    #endif
    [IsoXmlTag("LkSetOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LinkSetOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LinkSetOrderIdentification { get; init; } 
    #else
    public System.String? LinkSetOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the sequence in which the system will execute the liquidity transfers standing order within the link set when additional liquidity is required.
    /// </summary>
    [IsoId("_jNAKl5lPEee-Zps0fZQaFQ")]
    [DisplayName("Link Set Order Sequence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkSetOrdrSeq")]
    #endif
    [IsoXmlTag("LkSetOrdrSeq")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? LinkSetOrderSequence { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? LinkSetOrderSequence { get; init; } 
    #else
    public System.UInt64? LinkSetOrderSequence { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the query shall return all liquidity transfer standing orders defined as zero sweeping orders.
    /// When the indicator is set to true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
    /// </summary>
    [IsoId("_jNAKmZlPEee-Zps0fZQaFQ")]
    [DisplayName("Zero Sweep Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ZeroSweepInd")]
    #endif
    [IsoXmlTag("ZeroSweepInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ZeroSweepIndicator { get; init; } 
    #else
    public System.String? ZeroSweepIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
