// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity5Choice
{
    /// <summary>
    /// Quantity of financial instrument in the sub-balance expressed in a proprietary format.
    /// </summary>
    [IsoId("_1BQsa4jvEeONZKAAW4pOaQ")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : SubBalanceQuantity5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_JAok44jwEeONZKAAW4pOaQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public required IsoExact4AlphaNumericText Identification { get; init; } 
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_JAok5YjwEeONZKAAW4pOaQ")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Issuer { get; init; } 
        
        /// <summary>
        /// Short textual description of the scheme.
        /// </summary>
        [IsoId("_JAok54jwEeONZKAAW4pOaQ")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? SchemeName { get; init; } 
        
        /// <summary>
        /// Value of the balance.
        /// </summary>
        [IsoId("_JAok6YjwEeONZKAAW4pOaQ")]
        [DisplayName("Balance")]
        [IsoXmlTag("Bal")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Balance { get; init; } 
        
        
        #nullable disable
        
    }
}
