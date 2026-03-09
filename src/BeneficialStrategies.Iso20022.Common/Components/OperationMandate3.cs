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
/// Information specifying the Mandate.
/// </summary>
[IsoId("_QCGs4Q4fEeK3IMoVvcTkkg")]
[DisplayName("Operation Mandate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OperationMandate3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OperationMandate3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OperationMandate3( System.String reqIdentification,System.String reqRequiredSignatureNumber,System.String reqSignatureOrderIndicator )
    {
        Identification = reqIdentification;
        RequiredSignatureNumber = reqRequiredSignatureNumber;
        SignatureOrderIndicator = reqSignatureOrderIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_YiVBgA4fEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModCd")]
    #endif
    [IsoXmlTag("ModCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Modification1Code? ModificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Modification1Code? ModificationCode { get; init; } 
    #else
    public Modification1Code? ModificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the mandate.
    /// </summary>
    [IsoId("_QYmhVQ4fEeK3IMoVvcTkkg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Channel for which the operation mandate is valid. If ApplicableChannel equals Fax, this means that a bank operation instruction sent by fax will be processed according to the mandates exchanged in this message.
    /// </summary>
    [IsoId("_qK0XABg3EeKnW4lR85q-0A")]
    [DisplayName("Applicable Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblChanl")]
    #endif
    [IsoXmlTag("AplblChanl")]
    public ValueList<Channel2Choice_> ApplicableChannel { get; init; } = new ValueList<Channel2Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _qK0XABg3EeKnW4lR85q-0A
    
    /// <summary>
    /// Number of required and necessary signatures by the mandate.
    /// </summary>
    [IsoId("_QYmhXA4fEeK3IMoVvcTkkg")]
    [DisplayName("Required Signature Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdSgntrNb")]
    #endif
    [IsoXmlTag("ReqrdSgntrNb")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15PlusSignedNumericText RequiredSignatureNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RequiredSignatureNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RequiredSignatureNumber { get; init; } 
    #else
    public System.String RequiredSignatureNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator whether a certain order of signatures has to be respected or not.
    /// </summary>
    [IsoId("_QYmhYw4fEeK3IMoVvcTkkg")]
    [DisplayName("Signature Order Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgntrOrdrInd")]
    #endif
    [IsoXmlTag("SgntrOrdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SignatureOrderIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SignatureOrderIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SignatureOrderIndicator { get; init; } 
    #else
    public System.String SignatureOrderIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Holder of the mandate.
    /// </summary>
    [IsoId("_QYmhag4fEeK3IMoVvcTkkg")]
    [DisplayName("Mandate Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtHldr")]
    #endif
    [IsoXmlTag("MndtHldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndAuthorisation3? MandateHolder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndAuthorisation3? MandateHolder { get; init; } 
    #else
    public PartyAndAuthorisation3? MandateHolder { get; set; } 
    #endif
    
    /// <summary>
    /// Bank operation allowed by a mandate.
    /// </summary>
    [IsoId("_QYmhcQ4fEeK3IMoVvcTkkg")]
    [DisplayName("Bank Operation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkOpr")]
    #endif
    [IsoXmlTag("BkOpr")]
    public ValueList<BankTransactionCodeStructure4> BankOperation { get; init; } = new ValueList<BankTransactionCodeStructure4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _QYmhcQ4fEeK3IMoVvcTkkg
    
    /// <summary>
    /// Is the date when the mandate becomes valid.
    /// </summary>
    [IsoId("_QYmheA4fEeK3IMoVvcTkkg")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Is the date when the mandate stops to be valid.
    /// </summary>
    [IsoId("_QYmhfw4fEeK3IMoVvcTkkg")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EndDate { get; init; } 
    #else
    public System.DateOnly? EndDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
