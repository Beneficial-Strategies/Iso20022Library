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
/// Balance of a financial instrument for a specific statement page.
/// </summary>
[IsoId("_RFBsYNp-Ed-ak6NoX_4Aeg_389014624")]
[DisplayName("Pagination Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaginationBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Opening balance of the financial instrument in the statement.
    /// </summary>
    [IsoId("_RFBsYdp-Ed-ak6NoX_4Aeg_777817466")]
    [DisplayName("First Opening Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstOpngBal")]
    #endif
    [IsoXmlTag("FrstOpngBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? FirstOpeningBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? FirstOpeningBalance { get; init; } 
    #else
    public FinancialInstrumentQuantity1? FirstOpeningBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Opening balance of this page only. It must be the interemdiary closing balance of the previous page (part of the same statement).
    /// </summary>
    [IsoId("_RFBsYtp-Ed-ak6NoX_4Aeg_777817508")]
    [DisplayName("Intermediary Opening Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyOpngBal")]
    #endif
    [IsoXmlTag("IntrmyOpngBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? IntermediaryOpeningBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? IntermediaryOpeningBalance { get; init; } 
    #else
    public FinancialInstrumentQuantity1? IntermediaryOpeningBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Closing balance of the financial instrument in the statement.
    /// </summary>
    [IsoId("_RFBsY9p-Ed-ak6NoX_4Aeg_777817561")]
    [DisplayName("Final Closing Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlClsgBal")]
    #endif
    [IsoXmlTag("FnlClsgBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? FinalClosingBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? FinalClosingBalance { get; init; } 
    #else
    public FinancialInstrumentQuantity1? FinalClosingBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Closing Balance of this page only. Must be the interemdiary opening balance of the next page (part of the same statement).
    /// </summary>
    [IsoId("_RFBsZNp-Ed-ak6NoX_4Aeg_777817933")]
    [DisplayName("Intermediary Closing Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyClsgBal")]
    #endif
    [IsoXmlTag("IntrmyClsgBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? IntermediaryClosingBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? IntermediaryClosingBalance { get; init; } 
    #else
    public FinancialInstrumentQuantity1? IntermediaryClosingBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
