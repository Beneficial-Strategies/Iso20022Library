// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics1Choice
{
    /// <summary>
    /// Quantity of the goods, as proven by the certificate.
    /// </summary>
    [IsoId("_TnJq7dp-Ed-ak6NoX_4Aeg_913114272")]
    [DisplayName("Quantity")]
    public partial record Quantity : CertifiedCharacteristics1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the unit of measurement. For example, kilo, tons.
        /// </summary>
        [IsoId("_SqpmZtp-Ed-ak6NoX_4Aeg_-972518572")]
        [DisplayName("Unit Of Measure Code")]
        [IsoXmlTag("UnitOfMeasrCd")]
        public required UnitOfMeasure4Code UnitOfMeasureCode { get; init; } 
        
        /// <summary>
        /// Identifies the unit of measure not present in the code list.
        /// </summary>
        [IsoId("_SqpmZ9p-Ed-ak6NoX_4Aeg_-972518480")]
        [DisplayName("Other Unit Of Measure")]
        [IsoXmlTag("OthrUnitOfMeasr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text OtherUnitOfMeasure { get; init; } 
        
        /// <summary>
        /// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
        /// </summary>
        [IsoId("_SqpmaNp-Ed-ak6NoX_4Aeg_-972518633")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Value { get; init; } 
        
        /// <summary>
        /// Multiplication factor of measurement values. For example: goods that can be ordered by 36 pieces.
        /// </summary>
        [IsoId("_Sqpmadp-Ed-ak6NoX_4Aeg_-972518541")]
        [DisplayName("Factor")]
        [IsoXmlTag("Fctr")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        public IsoMax15NumericText? Factor { get; init; } 
        
        
        #nullable disable
        
    }
}
