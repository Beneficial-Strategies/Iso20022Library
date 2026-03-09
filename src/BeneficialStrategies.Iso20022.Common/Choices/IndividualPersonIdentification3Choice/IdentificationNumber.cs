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
namespace BeneficialStrategies.Iso20022.Choices.IndividualPersonIdentification3Choice
{
    /// <summary>
    /// Identification of the person that owns the account.
    /// </summary>
    [IsoId("_G6_50YoWEeahcZ3Nzs1Qag")]
    [DisplayName("Identification Number")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IdentificationNumber : IndividualPersonIdentification3Choice_
    #else
    public partial class IdentificationNumber : IndividualPersonIdentification3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a IdentificationNumber instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public IdentificationNumber( System.String reqIdentification,OtherIdentification3Choice_ reqIdentificationType )
        {
            Identification = reqIdentification;
            IdentificationType = reqIdentificationType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of a party, such as a tax or social security identifier.
        /// </summary>
        [IsoId("_ULIwYyFVEeWgV9SQSyaAog")]
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
        /// Type of identification.
        /// </summary>
        [IsoId("_hjcOQCFVEeWgV9SQSyaAog")]
        [DisplayName("Identification Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IdTp")]
        #endif
        [IsoXmlTag("IdTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OtherIdentification3Choice_ IdentificationType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required OtherIdentification3Choice_ IdentificationType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OtherIdentification3Choice_ IdentificationType { get; init; } 
        #else
        public OtherIdentification3Choice_ IdentificationType { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
