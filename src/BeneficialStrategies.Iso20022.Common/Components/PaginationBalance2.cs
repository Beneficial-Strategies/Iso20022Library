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
[IsoId("_s56c4QgGEeSxsfb1OEDVsw")]
[DisplayName("Pagination Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaginationBalance2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Opening balance of the financial instrument in the statement or of the intermediary opening balance of the page of the statement.
    /// </summary>
    [IsoId("_1WSMQAgGEeSxsfb1OEDVsw")]
    [DisplayName("Opening Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngBal")]
    #endif
    [IsoXmlTag("OpngBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OpeningBalance3Choice_? OpeningBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OpeningBalance3Choice_? OpeningBalance { get; init; } 
    #else
    public OpeningBalance3Choice_? OpeningBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Closing balance of the financial instrument in the statement or of the intermediary closing balance of the page of the statement.
    /// </summary>
    [IsoId("_ehLAQAgHEeSxsfb1OEDVsw")]
    [DisplayName("Closing Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgBal")]
    #endif
    [IsoXmlTag("ClsgBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClosingBalance3Choice_? ClosingBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingBalance3Choice_? ClosingBalance { get; init; } 
    #else
    public ClosingBalance3Choice_? ClosingBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
