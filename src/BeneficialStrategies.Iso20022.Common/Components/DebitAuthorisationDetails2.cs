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
/// Provides the reason for requesting a debit authorisation as well as the amount of the requested debit.
/// </summary>
[IsoId("_T9gVZdp-Ed-ak6NoX_4Aeg_-1628758235")]
[DisplayName("Debit Authorisation Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DebitAuthorisationDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DebitAuthorisationDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DebitAuthorisationDetails2( CancellationReason3Code reqCancellationReason )
    {
        CancellationReason = reqCancellationReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the reason for cancellation.
    /// </summary>
    [IsoId("_T9gVZtp-Ed-ak6NoX_4Aeg_-1628758200")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationReason3Code CancellationReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancellationReason3Code CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationReason3Code CancellationReason { get; init; } 
    #else
    public CancellationReason3Code CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_T9gVZ9p-Ed-ak6NoX_4Aeg_-1628757867")]
    [DisplayName("Amount To Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtToDbt")]
    #endif
    [IsoXmlTag("AmtToDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? AmountToDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? AmountToDebit { get; init; } 
    #else
    public CurrencyAndAmount? AmountToDebit { get; set; } 
    #endif
    
    /// <summary>
    /// Value date for debiting the amount.
    /// </summary>
    [IsoId("_T9gVaNp-Ed-ak6NoX_4Aeg_-1628757850")]
    [DisplayName("Value Date To Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDtToDbt")]
    #endif
    [IsoXmlTag("ValDtToDbt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValueDateToDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValueDateToDebit { get; init; } 
    #else
    public System.DateOnly? ValueDateToDebit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
