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
[IsoId("_ePYU17QXEeeKRKrD60ELBQ")]
[DisplayName("Borrower Lending Deadline")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BorrowerLendingDeadline3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BorrowerLendingDeadline3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BorrowerLendingDeadline3( DateFormat43Choice_ reqStockLendingDeadline,PartyIdentification92Choice_ reqBorrower )
    {
        StockLendingDeadline = reqStockLendingDeadline;
        Borrower = reqBorrower;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event for which the underlying security is out on loan.
    /// </summary>
    [IsoId("_eeQeEbQXEeeKRKrD60ELBQ")]
    [DisplayName("Stock Lending Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockLndgDdln")]
    #endif
    [IsoXmlTag("StockLndgDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat43Choice_ StockLendingDeadline { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat43Choice_ StockLendingDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat43Choice_ StockLendingDeadline { get; init; } 
    #else
    public DateFormat43Choice_ StockLendingDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Party who has borrowed stocks on loan.
    /// </summary>
    [IsoId("_eeQeE7QXEeeKRKrD60ELBQ")]
    [DisplayName("Borrower")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brrwr")]
    #endif
    [IsoXmlTag("Brrwr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification92Choice_ Borrower { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification92Choice_ Borrower { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification92Choice_ Borrower { get; init; } 
    #else
    public PartyIdentification92Choice_ Borrower { get; set; } 
    #endif
    
    
    #nullable disable
    
}
