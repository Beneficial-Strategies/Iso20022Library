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
/// Defines the criteria used to report on standing orders.
/// </summary>
[IsoId("_72-v8aMgEeCJ6YNENx4h-w_1129668542")]
[DisplayName("Standing Order Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StandingOrderReturnCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the criteria used to report on a multilateral balance.
    /// </summary>
    [IsoId("_72-v8qMgEeCJ6YNENx4h-w_1131789573")]
    [DisplayName("Standing Order Identification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdrIdInd")]
    #endif
    [IsoXmlTag("StgOrdrIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? StandingOrderIdentificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StandingOrderIdentificationIndicator { get; init; } 
    #else
    public System.String? StandingOrderIdentificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the standing order type is requested.
    /// </summary>
    [IsoId("_72-v86MgEeCJ6YNENx4h-w_-1572131023")]
    [DisplayName("Type Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpInd")]
    #endif
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? TypeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TypeIndicator { get; init; } 
    #else
    public System.String? TypeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the system member identification is requested.
    /// </summary>
    [IsoId("_72-v9KMgEeCJ6YNENx4h-w_2068552367")]
    [DisplayName("System Member Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysMmbInd")]
    #endif
    [IsoXmlTag("SysMmbInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SystemMemberIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SystemMemberIndicator { get; init; } 
    #else
    public System.String? SystemMemberIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the responsible party identification is requested.
    /// </summary>
    [IsoId("_72-v9aMgEeCJ6YNENx4h-w_-1772327660")]
    [DisplayName("Responsible Party Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnsblPtyInd")]
    #endif
    [IsoXmlTag("RspnsblPtyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ResponsiblePartyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResponsiblePartyIndicator { get; init; } 
    #else
    public System.String? ResponsiblePartyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account currency is requested.
    /// </summary>
    [IsoId("_72-v9qMgEeCJ6YNENx4h-w_58595509")]
    [DisplayName("Currency Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyInd")]
    #endif
    [IsoXmlTag("CcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CurrencyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CurrencyIndicator { get; init; } 
    #else
    public System.String? CurrencyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_73H54KMgEeCJ6YNENx4h-w_512682778")]
    [DisplayName("Debtor Account Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcctInd")]
    #endif
    [IsoXmlTag("DbtrAcctInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? DebtorAccountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DebtorAccountIndicator { get; init; } 
    #else
    public System.String? DebtorAccountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the multilateral limit is requested.
    /// </summary>
    [IsoId("_73H54aMgEeCJ6YNENx4h-w_501584001")]
    [DisplayName("Creditor Account Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcctInd")]
    #endif
    [IsoXmlTag("CdtrAcctInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CreditorAccountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorAccountIndicator { get; init; } 
    #else
    public System.String? CreditorAccountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the associated pool account is requested.
    /// </summary>
    [IsoId("_73H54qMgEeCJ6YNENx4h-w_-721838563")]
    [DisplayName("Associated Pool Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdPoolAcct")]
    #endif
    [IsoXmlTag("AssoctdPoolAcct")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AssociatedPoolAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedPoolAccount { get; init; } 
    #else
    public System.String? AssociatedPoolAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the frequency is requested.
    /// </summary>
    [IsoId("_73H546MgEeCJ6YNENx4h-w_942244873")]
    [DisplayName("Frequency Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrqcyInd")]
    #endif
    [IsoXmlTag("FrqcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? FrequencyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FrequencyIndicator { get; init; } 
    #else
    public System.String? FrequencyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the execution type is requested.
    /// </summary>
    [IsoId("_73H55KMgEeCJ6YNENx4h-w_-291151916")]
    [DisplayName("Execution Type Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnTpInd")]
    #endif
    [IsoXmlTag("ExctnTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ExecutionTypeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExecutionTypeIndicator { get; init; } 
    #else
    public System.String? ExecutionTypeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account standing order is requested.
    /// </summary>
    [IsoId("_73H55aMgEeCJ6YNENx4h-w_1111985929")]
    [DisplayName("Validity From Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyFrInd")]
    #endif
    [IsoXmlTag("VldtyFrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ValidityFromIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ValidityFromIndicator { get; init; } 
    #else
    public System.String? ValidityFromIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account owner information is requested.
    /// </summary>
    [IsoId("_73H55qMgEeCJ6YNENx4h-w_-886872152")]
    [DisplayName("Valid To Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldToInd")]
    #endif
    [IsoXmlTag("VldToInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ValidToIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ValidToIndicator { get; init; } 
    #else
    public System.String? ValidToIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the link set identification is requested.
    /// </summary>
    [IsoId("_73H556MgEeCJ6YNENx4h-w_-897970929")]
    [DisplayName("Link Set Identification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkSetIdInd")]
    #endif
    [IsoXmlTag("LkSetIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? LinkSetIdentificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LinkSetIdentificationIndicator { get; init; } 
    #else
    public System.String? LinkSetIdentificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the identification of a standing order within a link set is requested.
    /// </summary>
    [IsoId("_73Rq4KMgEeCJ6YNENx4h-w_1831649883")]
    [DisplayName("Link Set Order Identification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkSetOrdrIdInd")]
    #endif
    [IsoXmlTag("LkSetOrdrIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? LinkSetOrderIdentificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LinkSetOrderIdentificationIndicator { get; init; } 
    #else
    public System.String? LinkSetOrderIdentificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the sequence of a standing order within a link set is requested.
    /// </summary>
    [IsoId("_73Rq4aMgEeCJ6YNENx4h-w_834577530")]
    [DisplayName("Link Set Order Sequence Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkSetOrdrSeqInd")]
    #endif
    [IsoXmlTag("LkSetOrdrSeqInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? LinkSetOrderSequenceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LinkSetOrderSequenceIndicator { get; init; } 
    #else
    public System.String? LinkSetOrderSequenceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the total amount per standing order type is requested.
    /// </summary>
    [IsoId("_73Rq4qMgEeCJ6YNENx4h-w_175820900")]
    [DisplayName("Total Amount Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtInd")]
    #endif
    [IsoXmlTag("TtlAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? TotalAmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalAmountIndicator { get; init; } 
    #else
    public System.String? TotalAmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the zero sweeping indicator is requested.
    /// </summary>
    [IsoId("_73Rq46MgEeCJ6YNENx4h-w_1186558213")]
    [DisplayName("Zero Sweep Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ZeroSweepInd")]
    #endif
    [IsoXmlTag("ZeroSweepInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ZeroSweepIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ZeroSweepIndicator { get; init; } 
    #else
    public System.String? ZeroSweepIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
