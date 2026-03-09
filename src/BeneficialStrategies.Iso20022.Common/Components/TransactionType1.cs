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
/// Set of elements used to identify the transactions to be reported.
/// </summary>
[IsoId("_P9p0otp-Ed-ak6NoX_4Aeg_943039965")]
[DisplayName("Transaction Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionType1( EntryStatus2Code reqStatus,CreditDebitCode reqCreditDebitIndicator )
    {
        Status = reqStatus;
        CreditDebitIndicator = reqCreditDebitIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status on the books of the account servicer of the transactions to be reported.
    /// </summary>
    [IsoId("_P9p0o9p-Ed-ak6NoX_4Aeg_943040277")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EntryStatus2Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EntryStatus2Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EntryStatus2Code Status { get; init; } 
    #else
    public EntryStatus2Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the reporting request refers to credit or debit entries.
    /// </summary>
    [IsoId("_P9p0pNp-Ed-ak6NoX_4Aeg_943040000")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the minimum value of entries to be reported in the requested message.
    /// </summary>
    [IsoId("_P9p0pdp-Ed-ak6NoX_4Aeg_-1506075611")]
    [DisplayName("Floor Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlrLmt")]
    #endif
    [IsoXmlTag("FlrLmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Limit2? FloorLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Limit2? FloorLimit { get; init; } 
    #else
    public Limit2? FloorLimit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
