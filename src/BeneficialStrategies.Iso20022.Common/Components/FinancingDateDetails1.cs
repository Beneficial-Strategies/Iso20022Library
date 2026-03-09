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
/// Includes a set of dates (e.g. credit date) related to settlement of the financing amount.
/// </summary>
[IsoId("_T8KRktp-Ed-ak6NoX_4Aeg_1418174558")]
[DisplayName("Financing Date Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancingDateDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancingDateDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancingDateDetails1( System.DateOnly reqCreditDate )
    {
        CreditDate = reqCreditDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the financing transaction has been booked in an account.
    /// </summary>
    [IsoId("_T8KRk9p-Ed-ak6NoX_4Aeg_-558847054")]
    [DisplayName("Book Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookDt")]
    #endif
    [IsoXmlTag("BookDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BookDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BookDate { get; init; } 
    #else
    public System.DateOnly? BookDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a financed amount has been credited.
    /// </summary>
    [IsoId("_T8KRlNp-Ed-ak6NoX_4Aeg_-183898526")]
    [DisplayName("Credit Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDt")]
    #endif
    [IsoXmlTag("CdtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate CreditDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly CreditDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly CreditDate { get; init; } 
    #else
    public System.DateOnly CreditDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a financed amount has been debited.
    /// </summary>
    [IsoId("_T8KRldp-Ed-ak6NoX_4Aeg_-69382352")]
    [DisplayName("Debit Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtDt")]
    #endif
    [IsoXmlTag("DbtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DebitDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DebitDate { get; init; } 
    #else
    public System.DateOnly? DebitDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
