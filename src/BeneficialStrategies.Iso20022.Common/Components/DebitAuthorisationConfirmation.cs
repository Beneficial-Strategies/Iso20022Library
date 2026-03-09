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
/// Indicates if the debit authorisation is granted or not.
/// </summary>
[IsoId("_T9WkaNp-Ed-ak6NoX_4Aeg_2085142381")]
[DisplayName("Debit Authorisation Confirmation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DebitAuthorisationConfirmation
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DebitAuthorisationConfirmation instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DebitAuthorisationConfirmation( System.String reqDebitAuthorisation )
    {
        DebitAuthorisation = reqDebitAuthorisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code expressing the decision taken by the account owner relative to the request for debit authorization.
    /// </summary>
    [IsoId("_T9Wkadp-Ed-ak6NoX_4Aeg_2126703723")]
    [DisplayName("Debit Authorisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtAuthstn")]
    #endif
    [IsoXmlTag("DbtAuthstn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator DebitAuthorisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DebitAuthorisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DebitAuthorisation { get; init; } 
    #else
    public System.String DebitAuthorisation { get; set; } 
    #endif
    
    /// <summary>
    /// Amount authorised for debit. The party providing the debit authority may want to authorise the amount less charges and they may only be prepared to approve the debit for value today rather than the original value date.
    /// </summary>
    [IsoId("_T9Wkatp-Ed-ak6NoX_4Aeg_884935578")]
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
    [IsoId("_T9Wka9p-Ed-ak6NoX_4Aeg_884935673")]
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
    /// Justification of the (partial) debit authorisation.
    /// </summary>
    [IsoId("_T9WkbNp-Ed-ak6NoX_4Aeg_-1553869979")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reason { get; init; } 
    #else
    public System.String? Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
