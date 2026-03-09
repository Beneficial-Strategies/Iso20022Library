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
/// Statement information of an account.
/// </summary>
[IsoId("_mIue8TaqEeyjpIf0r_Ojqw")]
[DisplayName("Account Statement Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountStatementData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date the statement is generated.
    /// </summary>
    [IsoId("_mNrQYTaqEeyjpIf0r_Ojqw")]
    [DisplayName("Statement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDt")]
    #endif
    [IsoXmlTag("StmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StatementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StatementDate { get; init; } 
    #else
    public System.DateOnly? StatementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time the account statement is generated.
    /// </summary>
    [IsoId("_mNrQYzaqEeyjpIf0r_Ojqw")]
    [DisplayName("Statement Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtTm")]
    #endif
    [IsoXmlTag("StmtTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? StatementTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? StatementTime { get; init; } 
    #else
    public System.TimeOnly? StatementTime { get; set; } 
    #endif
    
    /// <summary>
    /// Statement information.
    /// </summary>
    [IsoId("_mNrQZTaqEeyjpIf0r_Ojqw")]
    [DisplayName("Account Statement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctStmt")]
    #endif
    [IsoXmlTag("AcctStmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountStatementDetails2? AccountStatement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountStatementDetails2? AccountStatement { get; init; } 
    #else
    public AccountStatementDetails2? AccountStatement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
