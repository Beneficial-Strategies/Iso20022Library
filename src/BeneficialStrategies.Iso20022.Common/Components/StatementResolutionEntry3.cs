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
/// Provides further details on the statement entry for the resolution of the investigation.
/// </summary>
[IsoId("_b3LNkdwYEee0mvR9H3APRg")]
[DisplayName("Statement Resolution Entry")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatementResolutionEntry3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_cHruw9wYEee0mvR9H3APRg")]
    [DisplayName("Original Group Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInf")]
    #endif
    [IsoXmlTag("OrgnlGrpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation29? OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    [IsoId("_cHruxdwYEee0mvR9H3APRg")]
    [DisplayName("Original Statement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlStmtId")]
    #endif
    [IsoXmlTag("OrgnlStmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalStatementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalStatementIdentification { get; init; } 
    #else
    public System.String? OriginalStatementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the entry.
    /// </summary>
    [IsoId("_cHrux9wYEee0mvR9H3APRg")]
    [DisplayName("Account Servicer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrRef")]
    #endif
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountServicerReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountServicerReference { get; init; } 
    #else
    public System.String? AccountServicerReference { get; set; } 
    #endif
    
    /// <summary>
    /// Corrected debit or credit amount, compared to the original entry where the amount is incorrect.||Usage: This amount may only be present if an incorrect statement entry has been reported.
    /// </summary>
    [IsoId("_cHruydwYEee0mvR9H3APRg")]
    [DisplayName("Corrected Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrctdAmt")]
    #endif
    [IsoXmlTag("CrrctdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? CorrectedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? CorrectedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? CorrectedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the charges included in the original entry amount.
    /// </summary>
    [IsoId("_cHruy9wYEee0mvR9H3APRg")]
    [DisplayName("Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrgs")]
    #endif
    [IsoXmlTag("Chrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charges3? Charges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charges3? Charges { get; init; } 
    #else
    public Charges3? Charges { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_cHruzdwYEee0mvR9H3APRg")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Purpose2Choice_? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Purpose2Choice_? Purpose { get; init; } 
    #else
    public Purpose2Choice_? Purpose { get; set; } 
    #endif
    
    
    #nullable disable
    
}
