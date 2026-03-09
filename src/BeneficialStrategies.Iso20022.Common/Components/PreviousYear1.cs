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
/// Choice between selected investment plans issued during previous years or the entirety of the investment plans.
/// </summary>
[IsoId("_SvkiqNp-Ed-ak6NoX_4Aeg_-248329088")]
[DisplayName("Previous Year")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PreviousYear1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PreviousYear1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PreviousYear1( System.String reqAllPreviousYears,System.String reqCashComponentIndicator )
    {
        AllPreviousYears = reqAllPreviousYears;
        CashComponentIndicator = reqCashComponentIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Selection ot the entirety of the investment plans.
    /// </summary>
    [IsoId("_Svkiqdp-Ed-ak6NoX_4Aeg_-248329010")]
    [DisplayName("All Previous Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllPrvsYrs")]
    #endif
    [IsoXmlTag("AllPrvsYrs")]
    [IsoSimpleType(IsoSimpleType.PreviousAll)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPreviousAll AllPreviousYears { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AllPreviousYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AllPreviousYears { get; init; } 
    #else
    public System.String AllPreviousYears { get; set; } 
    #endif
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_Svkiqtp-Ed-ak6NoX_4Aeg_-248328915")]
    [DisplayName("Specific Previous Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpcfcPrvsYrs")]
    #endif
    [IsoXmlTag("SpcfcPrvsYrs")]
    [IsoSimpleType(IsoSimpleType.ISOYear)]
    public SimpleValueList<System.UInt16> SpecificPreviousYears { get; init; } = new SimpleValueList<System.UInt16>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Svkiqtp-Ed-ak6NoX_4Aeg_-248328915
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_Svkiq9p-Ed-ak6NoX_4Aeg_306709098")]
    [DisplayName("Cash Component Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCmpntInd")]
    #endif
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CashComponentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CashComponentIndicator { get; init; } 
    #else
    public System.String CashComponentIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
