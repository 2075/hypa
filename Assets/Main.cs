// 
//		H Y P A S P A C E
//		A Generative Environment Visualization
//		2075@zero.io
// 

using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

using System.Collections;
using System.Collections.Generic;

using UnityEngine;

// using NLog;
// using NLog.Config;
// using NLog.Targets;

// using SubstrateNetApi;
// using SubstrateNetApi.Model.Calls;
// using SubstrateNetApi.Model.Rpc;
// using SubstrateNetApi.Model.Types;
// using SubstrateNetApi.Model.Types.Enum;
// using SubstrateNetApi.Model.Types.Struct;
// using SubstrateNetApi.TypeConverters;

public class Main : MonoBehaviour {

	// defaults

	public Entity creator;
	public Entity owner;
	public Entity controller;

	public Realm realm;
	public Context context;

	// generator

	public int seed = 49152;
	public int iteration = 0;

	// machine state

	public enum state {

		IDLE,
		READ,
		COMPUTE,
		WRITE,
		PANIC

	};

	// autonomous individual

	public struct Entity {

		string ID { get; set; }
		string Name { get; set; }
		string CID { get; set; }

	}

	// authority

	public struct Authority {

		string ID { get; set; }
		string Name { get; set; }
		string CID { get; set; }

		Entity creator;
		Entity owner;
		Entity controller;	

	}

	// metadata reference
	
	public struct Metadata {

		string cid;

		// TODO:
		// timestamp created
		// timestamp updated

		bool active; // intrinsic
		bool locked; // extrinsic

	}

	// a realm in metaverse

	public struct Realm {

		string ID;
		string name;
		string cid;

		Authority authority;

	}

	// context can live across realms 

	public struct Context {

		string ID;
		string name;
		string cid;

		Authority authority;
		Realm[] realms;

	}

	// asset classes bundle assets and
	// provide context for origin realms etc

	public struct AssetClass {

		string ID;
		string name;

		IEnumerable<Asset> Assets{ get; set; }

		Realm realm;
		Authority authority;
		Metadata meta;

	}

	// an asset

	public struct Asset {

		string ID;
		string name;

		Authority authority;
		Metadata meta;

		Realm realm;
		Context context;
		
		bool burnable;
		bool tradeable;

	}

	public struct AssetProperty {

		// dynamic props

	}


	// Start is called before the first frame update

	void Start() {

		// var WSSURL = "wss://alphaville.zero.io";
		// using var client = new SubstrateClient( new Uri( WSSURL ) );
		// await client.ConnectAsync( cancellationToken );

		Debug.Log("Hello");

	}

	// Update is called once per frame

	void Update() {

		iteration ++;

	}

}
