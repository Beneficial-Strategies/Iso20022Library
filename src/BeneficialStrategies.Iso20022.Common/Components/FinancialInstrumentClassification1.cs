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
/// The classification type of the financial instrument, eg, common share with voting right, fully paid and registered etc.
/// </summary>
[IsoId("_TuJqxdp-Ed-ak6NoX_4Aeg_1114148307")]
[DisplayName("Financial Instrument Classification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentClassification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentClassification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentClassification1( SecurityClassificationType1Choice_ reqClassificationType )
    {
        ClassificationType = reqClassificationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, eg, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_TuJqxtp-Ed-ak6NoX_4Aeg_1140931613")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityClassificationType1Choice_ ClassificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityClassificationType1Choice_ ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityClassificationType1Choice_ ClassificationType { get; init; } 
    #else
    public SecurityClassificationType1Choice_ ClassificationType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
