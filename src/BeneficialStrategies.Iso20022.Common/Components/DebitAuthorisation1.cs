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
[IsoId("_t4cl-FkyEeGeoaLUQk__nA_820376924")]
[DisplayName("Debit Authorisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DebitAuthorisation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DebitAuthorisation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DebitAuthorisation1( CancellationReason14Choice_ reqCancellationReason )
    {
        CancellationReason = reqCancellationReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_t4mW8FkyEeGeoaLUQk__nA_-2083539038")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationReason14Choice_ CancellationReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancellationReason14Choice_ CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationReason14Choice_ CancellationReason { get; init; } 
    #else
    public CancellationReason14Choice_ CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money requested for debit authorisation.
    /// </summary>
    [IsoId("_t4mW8VkyEeGeoaLUQk__nA_256189912")]
    [DisplayName("Amount To Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtToDbt")]
    #endif
    [IsoXmlTag("AmtToDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? AmountToDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? AmountToDebit { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? AmountToDebit { get; set; } 
    #endif
    
    /// <summary>
    /// Value date for debiting the amount.
    /// </summary>
    [IsoId("_t4mW8lkyEeGeoaLUQk__nA_108386986")]
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
    
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_t4mW81kyEeGeoaLUQk__nA_1939310155")]
    [DisplayName("Additional Cancellation Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCxlRsnInf")]
    #endif
    [IsoXmlTag("AddtlCxlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalCancellationReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalCancellationReasonInformation { get; init; } 
    #else
    public System.String? AdditionalCancellationReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
