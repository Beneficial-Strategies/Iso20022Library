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
namespace BeneficialStrategies.Iso20022.Choices.RegisteredShareholderName1Choice
{
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_yANgEFxYEeWvPv3PXpS3fw")]
    [DisplayName("Organisation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Organisation : RegisteredShareholderName1Choice_
    #else
    public partial class Organisation : RegisteredShareholderName1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Organisation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Organisation( System.String reqName )
        {
            Name = reqName;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_GqORAVxZEeWvPv3PXpS3fw")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax350Text Name { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Name { get; init; } 
        #else
        public System.String Name { get; set; } 
        #endif
        
        /// <summary>
        /// Name of the organisation in short form.
        /// </summary>
        [IsoId("_GqORA1xZEeWvPv3PXpS3fw")]
        [DisplayName("Short Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShrtNm")]
        #endif
        [IsoXmlTag("ShrtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ShortName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ShortName { get; init; } 
        #else
        public System.String? ShortName { get; set; } 
        #endif
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_GqORD1xZEeWvPv3PXpS3fw")]
        [DisplayName("Postal Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PstlAdr")]
        #endif
        [IsoXmlTag("PstlAdr")]
        [MinLength(1)]
        [MaxLength(5)]
        public ValueList<PostalAddress21> PostalAddress { get; init; } = new ValueList<PostalAddress21>(){};
        
        
        #nullable disable
        
    }
}
