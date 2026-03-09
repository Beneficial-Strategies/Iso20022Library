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
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
[IsoId("_70efBVhLEeih3fUfzR38Ig")]
[DisplayName("Party Reference Data Change")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyReferenceDataChange2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyReferenceDataChange2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyReferenceDataChange2( SystemPartyIdentification8 reqPartyIdentification,System.DateTime reqOperationTimeStamp )
    {
        PartyIdentification = reqPartyIdentification;
        OperationTimeStamp = reqOperationTimeStamp;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the party for which the changes are listed in the advice.
    /// </summary>
    [IsoId("_7_fcMVhLEeih3fUfzR38Ig")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification8 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyIdentification8 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification8 PartyIdentification { get; init; } 
    #else
    public SystemPartyIdentification8 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the party data record for which details of the change are provided.
    /// </summary>
    [IsoId("_E_5woIp8EeiEt5E1WBt_2Q")]
    [DisplayName("Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcrd")]
    #endif
    [IsoXmlTag("Rcrd")]
    public ValueList<UpdateLogPartyRecord1Choice_> Record { get; init; } = new ValueList<UpdateLogPartyRecord1Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _E_5woIp8EeiEt5E1WBt_2Q
    
    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    [IsoId("_7_fcOVhLEeih3fUfzR38Ig")]
    [DisplayName("Operation Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprTmStmp")]
    #endif
    [IsoXmlTag("OprTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime OperationTimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime OperationTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime OperationTimeStamp { get; init; } 
    #else
    public System.DateTime OperationTimeStamp { get; set; } 
    #endif
    
    
    #nullable disable
    
}
