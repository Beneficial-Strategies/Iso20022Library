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
/// Details of driving license.
/// </summary>
[IsoId("_JUVlIFzPEeeDqe2giKl0eQ")]
[DisplayName("Driving License")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DrivingLicense1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DrivingLicense1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DrivingLicense1( System.String reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of driving license.
    /// </summary>
    [IsoId("_ULFsQFzPEeeDqe2giKl0eQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Form of driving license.
    /// </summary>
    [IsoId("_fx27EFzPEeeDqe2giKl0eQ")]
    [DisplayName("Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Form")]
    #endif
    [IsoXmlTag("Form")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PresentationMedium2Code? Form { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PresentationMedium2Code? Form { get; init; } 
    #else
    public PresentationMedium2Code? Form { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the driver license (for example, driver license number).
    /// </summary>
    [IsoId("_o_nEEFzPEeeDqe2giKl0eQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Authority assigning an identification to a driver license.
    /// </summary>
    [IsoId("_Ssi1MFzQEeeDqe2giKl0eQ")]
    [DisplayName("Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnr")]
    #endif
    [IsoXmlTag("Assgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalStructure1Code? Assigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalStructure1Code? Assigner { get; init; } 
    #else
    public LegalStructure1Code? Assigner { get; set; } 
    #endif
    
    /// <summary>
    /// Date of issuance of the driving license.
    /// </summary>
    [IsoId("_clDLYFzQEeeDqe2giKl0eQ")]
    [DisplayName("Issuance Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssncDt")]
    #endif
    [IsoXmlTag("IssncDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? IssuanceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? IssuanceDate { get; init; } 
    #else
    public System.DateOnly? IssuanceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Expiration date of the driving license (if and when relevant).
    /// </summary>
    [IsoId("_kRaaIFzQEeeDqe2giKl0eQ")]
    [DisplayName("Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XprtnDt")]
    #endif
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpirationDate { get; init; } 
    #else
    public System.DateOnly? ExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Country issuing the driver license.
    /// </summary>
    [IsoId("_uLAVcFzQEeeDqe2giKl0eQ")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3AlphaText? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Country { get; init; } 
    #else
    public System.String? Country { get; set; } 
    #endif
    
    /// <summary>
    /// State issuing the driver license (if and when relevant).
    /// </summary>
    [IsoId("_7cuqMFzQEeeDqe2giKl0eQ")]
    [DisplayName("State")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Stat")]
    #endif
    [IsoXmlTag("Stat")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? State { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? State { get; init; } 
    #else
    public System.String? State { get; set; } 
    #endif
    
    /// <summary>
    /// Province issuing the driver license (if and when relevant).
    /// </summary>
    [IsoId("_IyfKYFzREeeDqe2giKl0eQ")]
    [DisplayName("Province")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prvc")]
    #endif
    [IsoXmlTag("Prvc")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? Province { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Province { get; init; } 
    #else
    public System.String? Province { get; set; } 
    #endif
    
    /// <summary>
    /// Other authority issuing a driver license.
    /// </summary>
    [IsoId("_POT-UFzREeeDqe2giKl0eQ")]
    [DisplayName("Other Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAuthrty")]
    #endif
    [IsoXmlTag("OthrAuthrty")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? OtherAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherAuthority { get; init; } 
    #else
    public System.String? OtherAuthority { get; set; } 
    #endif
    
    
    #nullable disable
    
}
