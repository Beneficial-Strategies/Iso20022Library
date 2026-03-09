// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification22Choice
{
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_B03cA1hxEeWDI58xzGOTTQ")]
    [DisplayName("Alternate Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AlternateIdentification : SecurityIdentification22Choice_
    #else
    public partial class AlternateIdentification : SecurityIdentification22Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AlternateIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AlternateIdentification( System.String reqIdentification,IdentificationSource1Choice_ reqIdentificationSource )
        {
            Identification = reqIdentification;
            IdentificationSource = reqIdentificationSource;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier of a security.
        /// </summary>
        [IsoId("_TBTL09p-Ed-ak6NoX_4Aeg_2021814610")]
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
        /// Source of the security identification.
        /// </summary>
        [IsoId("_TBTL1Np-Ed-ak6NoX_4Aeg_-1724730736")]
        [DisplayName("Identification Source")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IdSrc")]
        #endif
        [IsoXmlTag("IdSrc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IdentificationSource1Choice_ IdentificationSource { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required IdentificationSource1Choice_ IdentificationSource { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public IdentificationSource1Choice_ IdentificationSource { get; init; } 
        #else
        public IdentificationSource1Choice_ IdentificationSource { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
