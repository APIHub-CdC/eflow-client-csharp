using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IO.EflowPeru.Model
{
    [DataContract]
    public partial class Peticion :  IEquatable<Peticion>, IValidatableObject
    {
        [JsonConstructorAttribute]
        protected Peticion() { }
        public Peticion(string folio = default(string), string tipoDocumento = default(string), string numeroDocumento = default(string))
        {
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.Folio = folio;
        }
        
        [DataMember(Name="folio", EmitDefaultValue=false)]
        public string Folio { get; set; }
        [DataMember(Name="tipoDocumento", EmitDefaultValue=false)]
        public string TipoDocumento { get; set; }
        [DataMember(Name="numeroDocumento", EmitDefaultValue=false)]
        public string NumeroDocumento { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Peticion {\n");
            sb.Append("  Folio: ").Append(Folio).Append("\n");
            sb.Append("  TipoDocumento: ").Append(TipoDocumento).Append("\n");
            sb.Append("  NumeroDocumento: ").Append(NumeroDocumento).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Peticion);
        }
        public bool Equals(Peticion input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Folio == input.Folio ||
                    (this.Folio != null &&
                    this.Folio.Equals(input.Folio))
                ) && 
                (
                    this.TipoDocumento == input.TipoDocumento ||
                    (this.TipoDocumento != null &&
                    this.TipoDocumento.Equals(input.TipoDocumento))
                ) && 
                (
                    this.NumeroDocumento == input.NumeroDocumento ||
                    (this.NumeroDocumento != null &&
                    this.NumeroDocumento.Equals(input.NumeroDocumento))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Folio != null)
                    hashCode = hashCode * 59 + this.Folio.GetHashCode();
                if (this.TipoDocumento != null)
                    hashCode = hashCode * 59 + this.TipoDocumento.GetHashCode();
                if (this.NumeroDocumento != null)
                    hashCode = hashCode * 59 + this.NumeroDocumento.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.TipoDocumento != null && this.TipoDocumento.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TipoDocumento, length must be less than 2.", new [] { "TipoDocumento" });
            }
            if(this.NumeroDocumento != null && this.NumeroDocumento.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumeroDocumento, length must be less than 12.", new [] { "NumeroDocumento" });
            }
            yield break;
        }
    }
}