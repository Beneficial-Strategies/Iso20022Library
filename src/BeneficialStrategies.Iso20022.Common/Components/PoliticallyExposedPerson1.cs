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
/// Politically exposed person checks.
/// </summary>
[IsoId("_kC2a0KeeEemSUcvu_mDC7w")]
[DisplayName("Politically Exposed Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PoliticallyExposedPerson1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PoliticallyExposedPerson1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PoliticallyExposedPerson1( PoliticalExposureType2Choice_ reqPoliticallyExposedPersonType )
    {
        PoliticallyExposedPersonType = reqPoliticallyExposedPersonType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies if due diligence checks on the political exposure of the investor have been carried out. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.)
    /// </summary>
    [IsoId("_m5DL4qeeEemSUcvu_mDC7w")]
    [DisplayName("Politically Exposed Person Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PltclyXpsdPrsnTp")]
    #endif
    [IsoXmlTag("PltclyXpsdPrsnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PoliticalExposureType2Choice_ PoliticallyExposedPersonType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PoliticalExposureType2Choice_ PoliticallyExposedPersonType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PoliticalExposureType2Choice_ PoliticallyExposedPersonType { get; init; } 
    #else
    public PoliticalExposureType2Choice_ PoliticallyExposedPersonType { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the politically exposed person.
    /// </summary>
    [IsoId("_m5DL46eeEemSUcvu_mDC7w")]
    [DisplayName("Politically Exposed Person Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PltclyXpsdPrsnSts")]
    #endif
    [IsoXmlTag("PltclyXpsdPrsnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PoliticallyExposedPersonStatus1Choice_? PoliticallyExposedPersonStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PoliticallyExposedPersonStatus1Choice_? PoliticallyExposedPersonStatus { get; init; } 
    #else
    public PoliticallyExposedPersonStatus1Choice_? PoliticallyExposedPersonStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
