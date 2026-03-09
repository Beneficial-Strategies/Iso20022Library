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
[IsoId("_QPfxleGBEeWCAvUNsZ5u6g")]
[DisplayName("Securities Account Reference Data Change")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccountReferenceDataChange2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesAccountReferenceDataChange2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAccountReferenceDataChange2( SecuritiesAccount19 reqSecuritiesAccountIdentification,System.String reqFieldName,System.String reqOldFieldValue,System.String reqNewFieldValue,System.DateTime reqOperationTimeStamp )
    {
        SecuritiesAccountIdentification = reqSecuritiesAccountIdentification;
        FieldName = reqFieldName;
        OldFieldValue = reqOldFieldValue;
        NewFieldValue = reqNewFieldValue;
        OperationTimeStamp = reqOperationTimeStamp;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the securities account for which the changes are listed in the advice.
    /// </summary>
    [IsoId("_QaW9weGBEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctId")]
    #endif
    [IsoXmlTag("SctiesAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
    #else
    public SecuritiesAccount19 SecuritiesAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the element, as specified in the short tag name for the field in the message.
    /// </summary>
    [IsoId("_QaW9w-GBEeWCAvUNsZ5u6g")]
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
    [IsoId("_QaW9xeGBEeWCAvUNsZ5u6g")]
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
    [IsoId("_QaW9x-GBEeWCAvUNsZ5u6g")]
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
    [IsoId("_QaW9yeGBEeWCAvUNsZ5u6g")]
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
