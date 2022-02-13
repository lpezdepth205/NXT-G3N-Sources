#include "renderer.h"
#include "../../game/sdk.h"
#include <iostream>

namespace renderer {
	namespace scene {
		void start() {
			begin();
			clear();
		}

		void begin() {
			internal::render_target->BeginDraw();
		}
		
		void end() {
			internal::render_target->EndDraw();

			// code below is really just for convience, without the if statement you would have to
			// manually close each window as when clicking onto the game the focus doesnt close the 
			// other window. Comment it out and u will see what I mean. the statement fixes it
			// by brigning overlay to topmost (removes flag imdeallty) then putting game winodw
			// right under it 

			static bool toggle = true;
			if (GetForegroundWindow() == sdk::hwnd) {
				if (toggle) {
					SetWindowPos(hijack::hijacked_hwnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE);
					SetWindowPos(hijack::hijacked_hwnd, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE);
					ShowWindow(hijack::hijacked_hwnd, SW_SHOW);
					toggle = false;
				}
			}
			else {
				ShowWindow(hijack::hijacked_hwnd, SW_HIDE);
				toggle = true;
			}

			// sets game window under overlay
			SetWindowPos(sdk::hwnd, hijack::hijacked_hwnd, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
		}

		void clear() {
			internal::render_target->Clear();
		}

		void line(float x, float y, float x1, float y1, ID2D1SolidColorBrush* color)
		{
			D2D1_POINT_2F p1;
			p1.x = x;
			p1.y = y;
			D2D1_POINT_2F p2;
			p2.x = x1;
			p2.y = y1;
			internal::render_target->DrawLine(p1,p2,color, 1.0f);
		}

		void text(vec2_t pos, const wchar_t* text, ID2D1SolidColorBrush* color, IDWriteTextFormat* font) {
			internal::render_target->DrawTextA( text, lstrlenW( text ), font, pos.rect(), color, D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE_NATURAL );
		}

		void box(int x, int y, int width, int height, int thick, ID2D1SolidColorBrush* color) {
			internal::render_target->DrawRectangle(D2D1::RectF(x, y, x + width, y + height), color, thick);
		}

		void shutdown() {
			begin();
			clear();
			end();
		}
	}
}