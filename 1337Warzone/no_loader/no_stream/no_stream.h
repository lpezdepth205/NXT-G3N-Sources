#pragma once
#include <Windows.h>
#include <string>

typedef unsigned char databyte;

class BLOWFISH
{
	//Although there is no successful cryptanalysis of the 16 round version, a higher number of rounds generally means more security.
	//STANDARD: 16
	//MAXIMUM: 256
	//**MUST be an EVEN number**

#define ROUNDS 16

public:
	BLOWFISH(std::string hexKey);
	BLOWFISH(databyte* cipherKey, int keylength);

	//TODO: string encryption functions -> base64
	std::string Encrypt_CBC(std::string data);
	databyte* Encrypt_CBC(databyte* data, int length, int* newlength);
	databyte* Encrypt_ECB(databyte* data, int length, int* newlength);
	void Encrypt_Block(databyte* block, int offset = 0);

	std::string Decrypt_CBC(std::string data);
	databyte* Decrypt_CBC(databyte* data, int length, int* newlength);
	databyte* Decrypt_ECB(databyte* data, int length, int* newlength);
	void Decrypt_Block(databyte* block, int offset = 0);

	void SetRandomIV();
	void SetIV(databyte* newIV);
	databyte* GetIV();
	bool IvSet;

protected:
	void SetupKey(databyte* cipherKey, int length);
	void encipher();
	void decipher();
	unsigned int round(unsigned int a, unsigned int b, unsigned int n);
	void setblock(databyte* block, int offset);
	void getblock(databyte* block, int offset);
	static unsigned int p[];
	static unsigned int s0[];
	static unsigned int s1[];
	static unsigned int s2[];
	static unsigned int s3[];

	unsigned int xl_par;
	unsigned int xr_par;

	databyte IV[8];

	databyte* Crypt_ECB(databyte* data, int length, int* newlength, void (BLOWFISH::* CryptBlock)(databyte*, int offset), bool decrypt);
	databyte* Crypt_CBC(databyte* data, int length, int* newlength, void (BLOWFISH::* CryptBlock)(databyte*, int offset), bool decrypt);
	databyte* padData(databyte* data, int length, int* paddedLength, bool decrypt, bool IvSpace);
	int findPaddingEnd(databyte* data, int length);
	int hex2dec(char hex);
	std::string byteToHex(unsigned char x);
};

//blowfish.h
//This code is in the public domain.
//Created by Taylor Hornby 
//May 8, 2010.
//Ported from my C# blowfish code which was ported from the JavaScript crypto library found here:
//  http://etherhack.co.uk/symmetric/blowfish/blowfish.html
//Complies with the test vectors:  http://www.schneier.com/code/vectors.txt
//Description:
//  Blowfish is a keyed, symmetric block cipher, designed in 1993 by Bruce Schneier and
//  included in a large number of cipher suites and encryption products. Blowfish provides
//  a good encryption rate in software and no effective cryptanalysis of it has been found to date.
//Key Size: 32 to 448 bits
//Block Size: 64 bits
//Rounds: 16 (up to 256 rounds can be used with this class, change the '#define ROUNDS' line)
//More Information: http://www.schneier.com/paper-blowfish-fse.html and http://en.wikipedia.org/wiki/Blowfish_cipher

/*  Cryptography 101 - How to implement properly

This class provides two modes of encryption, CBC and ECB. With ECB, the same data encrypted with the same key will
produce the same result. Patterns will also be visible in the ciphertext. ECB mode should not be used unless it is
specifically needed. CBC mode ensures that no patterns are present in the ciphertext, and that the same data
encrypted with the same key, yeilds a different ciphertext.

Whenever encrypting data, ALWAYS verify the authenticity of the data BEFORE decrypting. To do this, use a HMAC:
token = HMAC(ciphertext, key)
Include this token with the data, and verify it by computing the HMAC again. This ensures that without the key,
an attacker cannot modify the ciphertext. This is especially important with CBC mode, without verification, the
attacker can control the value of the first block of plaintext by modifying the IV.

-   When using CBC mode, always use a random and unique IV. SetRandomIV() will do this for you.
-   Blowfish is only as secure as the encryption key you provide. To create a key from a password,
	run it through a hash algorithm such as SHA-256
*/

/* Usage example
#include <iostream>
#include <string.h>
#include "blowfish.h"
using namespace std;
typedef unsigned char byte;
int main()
{
	BLOWFISH bf("FEDCBA9876543210");
	string asdf = "BlowwFIshhhhhhhhhhh!";
	asdf = bf.Encrypt_CBC(asdf);
	cout << "Encrypted: " << asdf << endl;
	asdf = bf.Decrypt_CBC(asdf);
	cout << "Decrypted: " << asdf;
	return 0;
}
*/