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
/// Specifies additional parameters to the message or transaction.
/// </summary>
[IsoId("_5mrXWZNLEeWGlc8L7oPDIg")]
[DisplayName("Additional Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalParameters26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether there exists a pre-confirmation.
    /// </summary>
    [IsoId("_5mrXXZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pre Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreConf")]
    #endif
    [IsoXmlTag("PreConf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreConfirmation1Code? PreConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreConfirmation1Code? PreConfirmation { get; init; } 
    #else
    public PreConfirmation1Code? PreConfirmation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies partial settlement information.
    /// </summary>
    [IsoId("_5mrXZZNLEeWGlc8L7oPDIg")]
    [DisplayName("Partial Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlSttlm")]
    #endif
    [IsoXmlTag("PrtlSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartialSettlement2Code? PartialSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartialSettlement2Code? PartialSettlement { get; init; } 
    #else
    public PartialSettlement2Code? PartialSettlement { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the confirmation previously sent to confirm the partial settlement of a transaction.
    /// </summary>
    [IsoId("_5mrXbZNLEeWGlc8L7oPDIg")]
    [DisplayName("Previous Partial Confirmation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsPrtlConfId")]
    #endif
    [IsoXmlTag("PrvsPrtlConfId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? PreviousPartialConfirmationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreviousPartialConfirmationIdentification { get; init; } 
    #else
    public System.String? PreviousPartialConfirmationIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
