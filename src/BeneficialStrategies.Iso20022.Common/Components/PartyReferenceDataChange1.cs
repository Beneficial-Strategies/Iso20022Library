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
[IsoId("_k2vBhO5NEeCisYr99QEiWA_-253138342")]
[DisplayName("Party Reference Data Change")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyReferenceDataChange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyReferenceDataChange1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyReferenceDataChange1( SystemPartyIdentification3 reqPartyIdentification,System.String reqFieldName,System.String reqOldFieldValue,System.String reqNewFieldValue,System.DateTime reqOperationTimeStamp )
    {
        PartyIdentification = reqPartyIdentification;
        FieldName = reqFieldName;
        OldFieldValue = reqOldFieldValue;
        NewFieldValue = reqNewFieldValue;
        OperationTimeStamp = reqOperationTimeStamp;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the party for which the changes are listed in the advice.
    /// </summary>
    [IsoId("_k24ygO5NEeCisYr99QEiWA_-763132473")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification3 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyIdentification3 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification3 PartyIdentification { get; init; } 
    #else
    public SystemPartyIdentification3 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the element, as specified in the short tag name for the field in the message.
    /// </summary>
    [IsoId("_k24yge5NEeCisYr99QEiWA_-366977408")]
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
    /// Value of the related field before the change was applied.
    /// </summary>
    [IsoId("_k24ygu5NEeCisYr99QEiWA_-1364049761")]
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
    /// Value of the related field after the change was applied.
    /// </summary>
    [IsoId("_k24yg-5NEeCisYr99QEiWA_-18100137")]
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
    
    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    [IsoId("_k24yhO5NEeCisYr99QEiWA_-1250210695")]
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
