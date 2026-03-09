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
/// Specifies the old and new values for a proprietary field name.
/// </summary>
[IsoId("_LituOGjOEeiRg5NzP0jkQg")]
[DisplayName("Update Log Proprietary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UpdateLogProprietary1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UpdateLogProprietary1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UpdateLogProprietary1( System.String reqFieldName,System.String reqOldFieldValue,System.String reqNewFieldValue )
    {
        FieldName = reqFieldName;
        OldFieldValue = reqOldFieldValue;
        NewFieldValue = reqNewFieldValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the field whose value has been changed.
    /// </summary>
    [IsoId("_LituOWjOEeiRg5NzP0jkQg")]
    [DisplayName("Field Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FldNm")]
    #endif
    [IsoXmlTag("FldNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text FieldName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FieldName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FieldName { get; init; } 
    #else
    public System.String FieldName { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the field before the change.
    /// </summary>
    [IsoId("_LituPmjOEeiRg5NzP0jkQg")]
    [DisplayName("Old Field Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OdFldVal")]
    #endif
    [IsoXmlTag("OdFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text OldFieldValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OldFieldValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OldFieldValue { get; init; } 
    #else
    public System.String OldFieldValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the field after the change.
    /// </summary>
    [IsoId("_LituPGjOEeiRg5NzP0jkQg")]
    [DisplayName("New Field Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewFldVal")]
    #endif
    [IsoXmlTag("NewFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text NewFieldValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NewFieldValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NewFieldValue { get; init; } 
    #else
    public System.String NewFieldValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
