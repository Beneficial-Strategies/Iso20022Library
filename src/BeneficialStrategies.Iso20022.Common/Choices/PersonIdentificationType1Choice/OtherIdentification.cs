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
namespace BeneficialStrategies.Iso20022.Choices.PersonIdentificationType1Choice
{
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    [IsoId("_QEW5mdp-Ed-ak6NoX_4Aeg_-315280529")]
    [DisplayName("Other Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OtherIdentification : PersonIdentificationType1Choice_
    #else
    public partial class OtherIdentification : PersonIdentificationType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OtherIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OtherIdentification( System.String reqIdentification,System.String reqIdentificationType )
        {
            Identification = reqIdentification;
            IdentificationType = reqIdentificationType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifier issued to a person for which no specific identifier has been defined.
        /// </summary>
        [IsoId("_P-sWddp-Ed-ak6NoX_4Aeg_-1304682662")]
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
        /// Specifies the nature of the identifier.|Usage: IdentificationType is used to specify what kind of identifier is used. It should be used in case the identifier is different from the identifiers listed in the pre-defined identifier list.
        /// </summary>
        [IsoId("_P-sWdtp-Ed-ak6NoX_4Aeg_-1601134417")]
        [DisplayName("Identification Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IdTp")]
        #endif
        [IsoXmlTag("IdTp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text IdentificationType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String IdentificationType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String IdentificationType { get; init; } 
        #else
        public System.String IdentificationType { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
