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
/// Set of elements used to further detail the information related to the type of payment.
/// </summary>
[IsoId("_cm369kjwEeaVLL5QKJ4f-A")]
[DisplayName("Mandate Type Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateTypeInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Agreement under which or rules under which the mandate resides.
    /// </summary>
    [IsoId("_cvK7QUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Service Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvl")]
    #endif
    [IsoXmlTag("SvcLvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    #else
    public ServiceLevel8Choice_? ServiceLevel { get; set; } 
    #endif
    
    /// <summary>
    /// User community specific instrument.|Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_cvK7Q0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Local Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclInstrm")]
    #endif
    [IsoXmlTag("LclInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    #else
    public LocalInstrument2Choice_? LocalInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the high level purpose of the mandate based on a set of pre-defined categories.
    /// </summary>
    [IsoId("_T6WPoUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Category Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtgyPurp")]
    #endif
    [IsoXmlTag("CtgyPurp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; } 
    #else
    public CategoryPurpose1Choice_? CategoryPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Type of direct debit instruction.
    /// </summary>
    [IsoId("_3MJbIGVREeacpJ-gG9kyUQ")]
    [DisplayName("Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clssfctn")]
    #endif
    [IsoXmlTag("Clssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MandateClassification1Choice_? Classification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateClassification1Choice_? Classification { get; init; } 
    #else
    public MandateClassification1Choice_? Classification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
