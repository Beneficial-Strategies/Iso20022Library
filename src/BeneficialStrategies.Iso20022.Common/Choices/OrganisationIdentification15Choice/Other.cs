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
namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentification15Choice
{
    /// <summary>
    /// Unique identification of an organisation, using a client code or a business identification code.
    /// </summary>
    [IsoId("_F-FycMgoEeuGrNSsxk3B0A")]
    [DisplayName("Other")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Other : OrganisationIdentification15Choice_
    #else
    public partial class Other : OrganisationIdentification15Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Other instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Other( GenericIdentification175 reqIdentification )
        {
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the organisation.
        /// </summary>
        [IsoId("_sAgPEMgnEeuGrNSsxk3B0A")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification175 Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification175 Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification175 Identification { get; init; } 
        #else
        public GenericIdentification175 Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the name of the organisation.
        /// </summary>
        [IsoId("_yyv-8MgnEeuGrNSsxk3B0A")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax105Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the domicile of the organisation.
        /// </summary>
        [IsoId("_8ndaQMgnEeuGrNSsxk3B0A")]
        [DisplayName("Domicile")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dmcl")]
        #endif
        [IsoXmlTag("Dmcl")]
        [IsoSimpleType(IsoSimpleType.Max500Text)]
        [StringLength(maximumLength: 500 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax500Text? Domicile { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Domicile { get; init; } 
        #else
        public System.String? Domicile { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
