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
/// Information about a custody statement of holdings.
/// </summary>
[IsoId("_UyjHA9p-Ed-ak6NoX_4Aeg_-1254942072")]
[DisplayName("Custody Statement Of Holdings")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustodyStatementOfHoldings1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustodyStatementOfHoldings1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustodyStatementOfHoldings1( Pagination reqMessagePagination )
    {
        MessagePagination = reqMessagePagination;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_UyjHBNp-Ed-ak6NoX_4Aeg_-1242798695")]
    [DisplayName("Message Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgPgntn")]
    #endif
    [IsoXmlTag("MsgPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination MessagePagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination MessagePagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination MessagePagination { get; init; } 
    #else
    public Pagination MessagePagination { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to the custody statement of holdings that is being cancelled.
    /// </summary>
    [IsoId("_UyjHBdp-Ed-ak6NoX_4Aeg_488546587")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Statement3? StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement3? StatementGeneralDetails { get; init; } 
    #else
    public Statement3? StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Safekeeping or investment account of the statement that is being cancelled.
    /// </summary>
    [IsoId("_UyjHBtp-Ed-ak6NoX_4Aeg_612299942")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingAccount1? AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingAccount1? AccountDetails { get; init; } 
    #else
    public SafekeepingAccount1? AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_UyjHB9p-Ed-ak6NoX_4Aeg_-972729362")]
    [DisplayName("Balance For Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalForAcct")]
    #endif
    [IsoXmlTag("BalForAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateBalanceInformation1? BalanceForAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateBalanceInformation1? BalanceForAccount { get; init; } 
    #else
    public AggregateBalanceInformation1? BalanceForAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_UyjHCNp-Ed-ak6NoX_4Aeg_-789871364")]
    [DisplayName("Sub Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctDtls")]
    #endif
    [IsoXmlTag("SubAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccountIdentification1? SubAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccountIdentification1? SubAccountDetails { get; init; } 
    #else
    public SubAccountIdentification1? SubAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_Uys4ANp-Ed-ak6NoX_4Aeg_-414920301")]
    [DisplayName("Total Values")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlVals")]
    #endif
    [IsoXmlTag("TtlVals")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalValueInPageAndStatement? TotalValues { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalValueInPageAndStatement? TotalValues { get; init; } 
    #else
    public TotalValueInPageAndStatement? TotalValues { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Uys4Adp-Ed-ak6NoX_4Aeg_46750019")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}
