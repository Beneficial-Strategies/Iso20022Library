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
/// Instructs the POI (Point Of Interaction) how to contact the host of the terminal management system (TMS), to initiate the maintenance of the terminal.
/// </summary>
[IsoId("_TGSgXAEcEeCQm6a_G2yO_w_-983555179")]
[DisplayName("TMS Trigger")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSTrigger1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSTrigger1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSTrigger1( TMSContactLevel1Code reqTMSContactLevel )
    {
        TMSContactLevel = reqTMSContactLevel;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Level of urgency in contacting the maintenance.
    /// </summary>
    [IsoId("_TGSgXQEcEeCQm6a_G2yO_w_-325386480")]
    [DisplayName("TMS Contact Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSCtctLvl")]
    #endif
    [IsoXmlTag("TMSCtctLvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TMSContactLevel1Code TMSContactLevel { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TMSContactLevel1Code TMSContactLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSContactLevel1Code TMSContactLevel { get; init; } 
    #else
    public TMSContactLevel1Code TMSContactLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the host to contact for the maintenance.
    /// </summary>
    [IsoId("_TGSgXgEcEeCQm6a_G2yO_w_-579683190")]
    [DisplayName("TMS Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSId")]
    #endif
    [IsoXmlTag("TMSId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TMSIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TMSIdentification { get; init; } 
    #else
    public System.String? TMSIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time for calling the maintenance.
    /// </summary>
    [IsoId("_TGSgXwEcEeCQm6a_G2yO_w_-1677507172")]
    [DisplayName("TMS Contact Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSCtctDtTm")]
    #endif
    [IsoXmlTag("TMSCtctDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TMSContactDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TMSContactDateTime { get; init; } 
    #else
    public System.DateTime? TMSContactDateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
