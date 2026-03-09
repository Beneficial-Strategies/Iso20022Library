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
/// Provides the list of criteria to be returned in the contract registration statement.
/// </summary>
[IsoId("_ZgWEUOFIEeStTblywAGIyA")]
[DisplayName("Contract Registration Statement Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractRegistrationStatementCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the journal of the transactions recorded under the registered currency control contract must be returned or not.
    /// </summary>
    [IsoId("_0pv6lOFIEeStTblywAGIyA")]
    [DisplayName("Transaction Journal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxJrnl")]
    #endif
    [IsoXmlTag("TxJrnl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TransactionJournal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionJournal { get; init; } 
    #else
    public System.String? TransactionJournal { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the journal of the supporting documents recorded under the registered currency control contract must be returned or not.
    /// </summary>
    [IsoId("_0pv6leFIEeStTblywAGIyA")]
    [DisplayName("Supporting Document Journal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpprtgDocJrnl")]
    #endif
    [IsoXmlTag("SpprtgDocJrnl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? SupportingDocumentJournal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SupportingDocumentJournal { get; init; } 
    #else
    public System.String? SupportingDocumentJournal { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the journal of additional supporting documents recorded under the registered currency control contract must be returned or not.
    /// </summary>
    [IsoId("_0pv6luFIEeStTblywAGIyA")]
    [DisplayName("Additional Supporting Document Journal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSpprtgDocJrnl")]
    #endif
    [IsoXmlTag("AddtlSpprtgDocJrnl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AdditionalSupportingDocumentJournal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalSupportingDocumentJournal { get; init; } 
    #else
    public System.String? AdditionalSupportingDocumentJournal { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the details on the currency control rule against which has been violated must be returned or not.
    /// </summary>
    [IsoId("_0pv6l-FIEeStTblywAGIyA")]
    [DisplayName("Regulatory Rule Validation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryRuleVldtn")]
    #endif
    [IsoXmlTag("RgltryRuleVldtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RegulatoryRuleValidation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegulatoryRuleValidation { get; init; } 
    #else
    public System.String? RegulatoryRuleValidation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
