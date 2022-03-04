using System;
using System.Collections.Generic;

namespace core.src.Entity {
	public class Client:IEquatable<Client> {
		string name;
		string lastName;
		int age;
		DateTime birthday;

		public Client ( ) {
		}

		public Client ( string name, string lastName, int age, DateTime birthday ) {
			this.name = name;
			this.lastName = lastName;
			this.age = age;
			this.birthday = birthday;
		}



		public override bool Equals ( object obj ) {
			return Equals (obj as Client);
		}

		public bool Equals ( Client other ) {
			return other != null &&
				   name == other.name &&
				   lastName == other.lastName &&
				   age == other.age &&
				   birthday == other.birthday;
		}

		public override int GetHashCode ( ) {
			int hashCode = 1506248272;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode (name);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode (lastName);
			hashCode = hashCode * -1521134295 + age.GetHashCode ( );
			hashCode = hashCode * -1521134295 + birthday.GetHashCode ( );
			return hashCode;
		}

		public static bool operator == ( Client left, Client right ) {
			return EqualityComparer<Client>.Default.Equals (left, right);
		}

		public static bool operator != ( Client left, Client right ) {
			return !(left == right);
		}
	}
}
