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
/// Stock lending deadline assigned to a borrower of the stock.
/// </summary>
[IsoId("_cs6FX_fSEeiNZp_PtLohLw")]
[DisplayName("Borrower Lending Deadline")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BorrowerLendingDeadline6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BorrowerLendingDeadline6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BorrowerLendingDeadline6( DateFormat49Choice_ reqStockLendingDeadline,PartyIdentification136Choice_ reqBorrower )
    {
        StockLendingDeadline = reqStockLendingDeadline;
        Borrower = reqBorrower;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event for which the underlying security is out on loan.
    /// </summary>
    [IsoId("_cs6FYffSEeiNZp_PtLohLw")]
    [DisplayName("Stock Lending Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockLndgDdln")]
    #endif
    [IsoXmlTag("StockLndgDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat49Choice_ StockLendingDeadline { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat49Choice_ StockLendingDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_ StockLendingDeadline { get; init; } 
    #else
    public DateFormat49Choice_ StockLendingDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Party who has borrowed stocks on loan.
    /// </summary>
    [IsoId("_cs6FY_fSEeiNZp_PtLohLw")]
    [DisplayName("Borrower")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brrwr")]
    #endif
    [IsoXmlTag("Brrwr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification136Choice_ Borrower { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification136Choice_ Borrower { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136Choice_ Borrower { get; init; } 
    #else
    public PartyIdentification136Choice_ Borrower { get; set; } 
    #endif
    
    
    #nullable disable
    
}
